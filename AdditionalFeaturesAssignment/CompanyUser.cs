using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    
   public class CompanyUser
    {
        public CompanyUser(string name) : this(name, "Jlk.05235.22")
        {

        }
        public CompanyUser(string name, string pass)
        {
            UserName = name;
            UserPassword = pass;
        }

        const string SecretQuestion = "What is your mothers maiden name?";
        string SecretAnswer { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
        

        
        }
    }
