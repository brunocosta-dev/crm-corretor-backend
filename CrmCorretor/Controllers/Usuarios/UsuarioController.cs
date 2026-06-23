using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmCorretor.Context;
using Microsoft.AspNetCore.Mvc;

namespace CrmCorretor.Controllers.Usuarios
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}