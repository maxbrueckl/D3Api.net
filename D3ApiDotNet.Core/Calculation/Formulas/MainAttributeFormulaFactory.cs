﻿using System.Collections.Generic;
using D3ApiDotNet.Core.Calculation.AttributeFetchers;
using D3ApiDotNet.Core.Objects.Item;

namespace D3ApiDotNet.Core.Calculation.Formulas
{
    public class MainAttributeFormulaFactory : AttributeFormulaFactory
    {
        public MainAttributeFormulaFactory(ElementalTermFactories factories, IAttributeFetcher mainAttributeFetcher, IList<Item> itemList, double heroLvl)
            : base(factories, mainAttributeFetcher, itemList, heroLvl, 3.0)
        {
        }
    }
}