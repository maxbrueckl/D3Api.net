﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using D3apiData.API;
using D3apiData.API.FilepathProviders;
using D3apiData.API.UrlConstruction;
using D3apiData.Persistence;
using D3apiData.WebClient;

namespace D3apiData
{
    class D3ApiServiceExample
    {
        private readonly ISerializer<Properties> _serializer = new SerializerXML<Properties>();
        private const string Configfile = @"config.xml";
        private ID3Collector _collector;

        public D3WebClient Webclient { get; set; }

        /// <summary>
        /// change properties in this object
        /// </summary>
        public Properties Config { get; set; }

        /// <summary>
        /// all data fetching goes through this object
        /// </summary>
        public D3Data Data { get; private set; }

        public D3ApiServiceExample()
        {
            LoadConfig();
            if (Config == null)
            {
                Config = new Properties(Locales.en_GB,CollectMode.TryCacheThenOnline);
                SaveConfig();
            }
            Config.PropertyChanged += new PropertyChangedEventHandler((o, args) => {
                                                                                       if (args.PropertyName !=
                                                                                           "CollectMode") return;
                                                                                       SetCollector(Config.CollectMode);
                                                                                       Data.Collector = _collector;
            });
            Config.PropertyChanged += new PropertyChangedEventHandler((o, args) => { if (args.PropertyName == "PropertyChanged") SaveConfig(); });
            Webclient = new D3WebClient();

            var mode = Config.CollectMode;
            SetCollector(mode);
            
            var urlConstructorList = new List<IUrlConstructionProvider>
            {
                new ProfileUrlConstructionProvider(),
                new HeroUrlConstructionProvider(),
                new ItemUrlConstructionProvider(),
                new ArtisanUrlConstructionProvider(),
                new FollowerUrlConstructionProvider(),
                new IconUrlConstructionProvider()
            };
            Data = new D3Data(Config, _collector, urlConstructorList);
        }

        public void SetCollector(CollectMode mode)
        {
            var defaultFilePathProvider = new DefaultFilePathProvider(); // end of chain
            var iconFilePathProvider = new IconFilePathProvider(defaultFilePathProvider);
            var itemFilePathProvider = new ItemFilePathProvider(iconFilePathProvider);
            var profileFilePathProvider = new ProfileFilePathProvider(itemFilePathProvider);
            var heroFilePathProvider = new HeroFilePathProvider(profileFilePathProvider); // begin of chain

            var cacheCollector = new CacheCollector(Config.CachePath, heroFilePathProvider);
            var onlineCollector = new OnlineCollector(Webclient);

            switch (mode)
            {
                case CollectMode.Online:
                    _collector = onlineCollector;
                    break;
                case CollectMode.Offline:
                    _collector = cacheCollector;
                    break;
                case CollectMode.TryCacheThenOnline:
                    _collector = new TryCacheThenOnlineCollector(cacheCollector, onlineCollector);
                    break;
                case CollectMode.OnlineWithCache:
                    _collector = new OnlineWithCacheCollector(cacheCollector, onlineCollector);
                    break;
            }
        }

        /// <summary>
        /// explicitely save config to file
        /// </summary>
        public void SaveConfig() {
            _serializer.Serialize(Config,Configfile);
        }

        /// <summary>
        /// explicitely load config from file
        /// </summary>
        public void LoadConfig()
        {
            try { 
                Config = _serializer.Deserialize(Configfile);
            }
            catch (InvalidOperationException)
            {
                Config = null;
            }
        }
    }
}
