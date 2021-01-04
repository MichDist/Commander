using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();

            //Create 
            CreateMap<CommandCreateDto, Command>();
            // Put
            CreateMap<CommandUpdateDto, Command>();
            //Patch
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
