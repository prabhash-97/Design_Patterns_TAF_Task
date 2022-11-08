using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_example
{
    public interface HomePge
    {
        void GoToPage();
        void Signup();
        void IsSignupSuccessful();
        void IsTitleExists();
        void Title();

    }
}
