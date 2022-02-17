using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation.UserInputBorder.interfaces
{
    public interface UserInput
    {
        T GetUserInput<T>(string question);
    }
}
