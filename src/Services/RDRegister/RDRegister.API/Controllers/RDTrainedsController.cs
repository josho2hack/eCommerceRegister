﻿using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RDRegister.API.Data;
using RDRegister.API.Dtos;
using RDRegister.API.Models;

namespace RDRegister.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RDTrainedsController : ControllerBase
    {
        private readonly IRegisterRepo _repository;
        private readonly IMapper _mapper;

        public RDTrainedsController(IRegisterRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RDTrainedReadDto>> GetAllTraineds()
        {
            var trainedItems = _repository.GetAllTraineds();
            return Ok(_mapper.Map<IEnumerable<RDTrainedReadDto>>(trainedItems));
        }

        [HttpGet("{id}", Name = "GetTrainedById")]
        public ActionResult<RDTrained> GetTrainedById(string id)
        {
            var trainedItem = _repository.GetTrainedById(id);
            if (trainedItem != null)
            {
                return Ok(_mapper.Map<RDTrainedReadDto>(trainedItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<RDTrainedReadDto> CreateTrained(RDTrainedCreateDto rdtCreateDto)
        {
            var rdtModel = _mapper.Map<RDTrained>(rdtCreateDto);
            var rdtReadDto = _mapper.Map<RDTrainedReadDto>(rdtModel);

            if (_repository.GetTrainedById(rdtModel.OfficerId) != null)
            {
                return Conflict(rdtReadDto);
            }

            _repository.CreateTrained(rdtModel);
            _repository.SaveChang();

            return CreatedAtRoute(nameof(GetTrainedById), new { id = rdtReadDto.OfficerId }, rdtReadDto);
        }

        [HttpPut("{id})"]
        public ActionResult UpdateTrained(string id,RDTrainedUpdateDto rdtUpdateDto)
        {

            return NoContent();
        }
    }
}
