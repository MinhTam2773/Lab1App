using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // enumeration types for relationship types
    public enum RelationshipType { Sister, Brother, Mother, Father };
    public class Relation
    {
        //private data
        private RelationshipType r; 

        //constructor
        public  Relation(RelationshipType r)
        {
            this.r = r;
        }

        //public method
        public string ShowRelationShip( Person person1, Person person2)
        {
            return $"Relationship between {person1.FirstName} and {person2.FirstName} is: {r}hood";
        }
    

    }
}
