using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace SisRh.WEB.Models.Util
{
    public class ControllerConfig : Controller
    {
        protected readonly IMapper _mapper;
        
        public ControllerConfig(IMapper mapper)
        {
            _mapper = mapper; 
        }
    } 
}
