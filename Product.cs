using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTestRun
{
    class Product
    {
        // ID
        private int _id;
        private String _name;
        private int _amount;

        //public Product(int _id, String _name, int _amount)
        //{
        //    this._id = _id;
        //    this._name = _name;
        //    this._amount = _amount;

        //}
        public int ProductId
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }

        }
        // Navn
        public String ProductName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        // Antal
        public int ProductAmount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        public override string ToString()
        {
            return $"et ekstra produkt: {ProductId}    {ProductName}   {ProductAmount}";
        }
    }
}

