using System;
using System.Collections.Generic;

namespace CsharpCollectionsAssignment.model
{
    public class FatCat : ICapitalist
    {
        private string name;
        private int salary;
        FatCat owner;

        public FatCat(string name, int salary) {
            this.name = name;
            this.salary = salary;
        }

        public FatCat(string name, int salary, FatCat owner) {
            this.name = name;
            this.salary = salary;
            this.owner = owner;
        }

        /**
         * @return the name of the capitalist
         */
        public string GetName() {
            return name;
        }

        /**
         * @return the salary of the capitalist, in dollars
         */
        public int GetSalary() {
            return salary;
        }

        /**
         * @return true if this element has a parent, or false otherwise
         */
        public bool HasParent() {
            return owner != null;
        }

        /**
         * @return the parent of this element, or null if this represents the top of a hierarchy
         */
        public FatCat GetParent() {
            return owner;
        }

        public override bool Equals(object obj)
        {
            var cat = obj as FatCat;
            return cat != null &&
                   name == cat.name &&
                   salary == cat.salary &&
                   EqualityComparer<FatCat>.Default.Equals(owner, cat.owner);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, salary, owner);
        }
    }
}