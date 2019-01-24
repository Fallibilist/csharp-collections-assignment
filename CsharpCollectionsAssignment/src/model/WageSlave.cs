using System;
using System.Collections.Generic;

namespace CsharpCollectionsAssignment.model
{
    public class WageSlave : ICapitalist
    {
        private string name;
        private int salary;
        FatCat owner;

        public WageSlave(string name, int salary) {
            this.name = name;
            this.salary = salary;
        }

        public WageSlave(string name, int salary, FatCat owner) {
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
            var slave = obj as WageSlave;
            return slave != null &&
                   name == slave.name &&
                   salary == slave.salary &&
                   EqualityComparer<FatCat>.Default.Equals(owner, slave.owner);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, salary, owner);
        }
    }
}