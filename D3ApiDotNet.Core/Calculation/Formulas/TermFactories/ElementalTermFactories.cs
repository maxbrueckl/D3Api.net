﻿using System;

namespace D3ApiDotNet.Core.Calculation.Formulas.TermFactories
{
    // verstößt gegen Open-Close-Principle, sorgt aber für DRY code.
    public class ElementalTermFactories
    {
        private readonly BaseTermFactory _baseFactory;
        private readonly SumTermFactory _sumFactory;
        private readonly ProductTermFactory _productFactory;
        private readonly SubstractionTermFactory _substractionFactory;
        private readonly DivisionTermFactory _divisionFactory;
        private readonly PercentSumTermFactory _percentSumFactory;
        private readonly AverageTermFactory _averageFactory;
        private readonly MaxTermFactory _maxFactory;

        public ElementalTermFactories(BaseTermFactory baseFactory, SumTermFactory sumFactory,
            ProductTermFactory productFactory, SubstractionTermFactory substractionFactory,
            DivisionTermFactory divisionFactory, PercentSumTermFactory percentSumFactory, AverageTermFactory averageFactory, MaxTermFactory maxFactory)
        {
            if (baseFactory == null) throw new ArgumentNullException("baseFactory");
            if (sumFactory == null) throw new ArgumentNullException("sumFactory");
            if (productFactory == null) throw new ArgumentNullException("productFactory");
            if (substractionFactory == null) throw new ArgumentNullException("substractionFactory");
            if (divisionFactory == null) throw new ArgumentNullException("divisionFactory");
            if (percentSumFactory == null) throw new ArgumentNullException("percentSumFactory");
            if (averageFactory == null) throw new ArgumentNullException("averageFactory");
            if (maxFactory == null) throw new ArgumentNullException("maxFactory");
            _baseFactory = baseFactory;
            _sumFactory = sumFactory;
            _productFactory = productFactory;
            _substractionFactory = substractionFactory;
            _divisionFactory = divisionFactory;
            _percentSumFactory = percentSumFactory;
            _averageFactory = averageFactory;
            _maxFactory = maxFactory;
        }

        public BaseTermFactory BaseFactory
        {
            get { return _baseFactory; }
        }

        public SumTermFactory SumFactory
        {
            get { return _sumFactory; }
        }

        public ProductTermFactory ProductFactory
        {
            get { return _productFactory; }
        }

        public SubstractionTermFactory SubstractionFactory
        {
            get { return _substractionFactory; }
        }

        public DivisionTermFactory DivisionFactory
        {
            get { return _divisionFactory; }
        }

        public PercentSumTermFactory PercentSumFactory
        {
            get { return _percentSumFactory; }
        }

        public AverageTermFactory AverageFactory
        {
            get { return _averageFactory; }
        }

        public MaxTermFactory MaxFactory
        {
            get { return _maxFactory; }
        }
    }
}
