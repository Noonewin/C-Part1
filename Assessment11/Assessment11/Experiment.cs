using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment11
{
    //Class that we use as a record of experimenet.
    class Experiment
    {
        //Private attributes.
        private string _name;
        private int expNumber;
        private string expDescription;
        private double _weight;
        private string _color;
        private double _volume;


        //Seting up constructors.
        public Experiment()
        {
            _name = "";
            expNumber = Int32.MinValue;
            expDescription = "";
            _weight = Double.MinValue;
            _volume = Double.MinValue;
            _color = "";
        }
        public Experiment(string name)
        {
            _name = name;
            expNumber = Int32.MinValue;
            expDescription = "";
            _weight = Double.MinValue;
            _volume = Double.MinValue;
            _color = "";
        }
        public Experiment(int number, string descrp)
        {
            _name = "";
            expNumber = number;
            expDescription = descrp;
            _weight = Double.MinValue;
            _volume = Double.MinValue;
            _color = "";
        }

        //Setters and getters for every class attribute.
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int experimentNumber
        {
            get { return expNumber; }
            set { expNumber = value; }
        }
        public string experimentDescription
        {
            get { return expDescription; }
            set { expDescription = value; }
        }
        public double weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public double volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
