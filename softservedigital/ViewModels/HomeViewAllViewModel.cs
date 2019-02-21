using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using softservedigital.Models;

namespace softservedigital.ViewModels
{
    public class HomeViewAllViewModel
    {
        public IEnumerable<UserDto> Users { get; set; }
    }
}
