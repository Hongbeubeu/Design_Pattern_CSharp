using System;
namespace Prototype
{
    public class Person
    {
        public int age;
        public DateTime birthDate;
        public string name;
        public IdInfo idInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.idInfo = new IdInfo(idInfo.idNumber);
            clone.name = name.ToString();
            return clone;
        }
    }

    public class IdInfo
    {
        public int idNumber;
        public IdInfo(int idNumber)
        {
            this.idNumber = idNumber;
        }
    }
}