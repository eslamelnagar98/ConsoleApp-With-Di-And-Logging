using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TestDi
    {
        private readonly IGreetingService _greetingService;
        public TestDi(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public void Islam()
        {
            _greetingService.Run();
        }

    }
}
