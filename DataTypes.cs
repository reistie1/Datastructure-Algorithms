using System;
namespace DatastructureAlgorithms.DataTypes
{
    public class DataType
    {
        public DataType(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return this.age + " " + this.name;
        }

        int age {get; set;}
        string name {get; set;}

    }
}