using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using D3ApiDotNet.Core.Objects.Images;
using D3ApiDotNet.Core.Objects.Item;
using D3ApiDotNet.DataAccess.Repositories;
using D3ApiDotNet.WpfUI.Annotations;
using D3ApiDotNet.WpfUI.ViewModels.Interfaces;

namespace D3ApiDotNet.WpfUI.ViewModels
{
    public class ItemViewModel : IItemViewModel
    {
        public ItemViewModel(bool hasTooltipEnabled, [NotNull] IItemDetailViewModel itemDetailViewModel)
        {
            if (itemDetailViewModel == null) throw new ArgumentNullException("itemDetailViewModel");
            HasTooltipEnabled = hasTooltipEnabled;
            ItemDetailViewModel = itemDetailViewModel;
        }

        public bool HasTooltipEnabled { get; set; }
        public IItemDetailViewModel ItemDetailViewModel { get; private set; }
    }
}