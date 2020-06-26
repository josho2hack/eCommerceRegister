using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RDRegister.API.Data;
using RDRegister.API.Dtos;
using RDRegister.API.Models;

namespace RDRegister.API.Controllers
{
    //[Authorize]
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
        public async Task<ActionResult<IEnumerable<RDTrainedReadDto>>> GetAllTrainedsAsync()
        {
            var trainedItems = await _repository.GetAllTrainedsAsync();
            return Ok(_mapper.Map<IEnumerable<RDTrainedReadDto>>(trainedItems));
        }

        [HttpGet("{id}", Name = "GetTrainedById")]
        public async Task<ActionResult<RDTrained>> GetTrainedByIdAsync(string id)
        {
            var trainedItem = await _repository.GetTrainedByIdAsync(id);
            if (trainedItem != null)
            {
                return Ok(_mapper.Map<RDTrainedReadDto>(trainedItem));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<RDTrainedReadDto>> CreateTrained(RDTrainedCreateDto rdtCreateDto)
        {
            var rdtModel = _mapper.Map<RDTrained>(rdtCreateDto);
            var rdtReadDto = _mapper.Map<RDTrainedReadDto>(rdtModel);

            if (await _repository.GetTrainedByIdAsync(rdtModel.OfficerId) != null)
            {
                return Conflict(rdtReadDto);
            }

            _repository.CreateTrained(rdtModel);
            await _repository.SaveChangsAsync();

            return CreatedAtRoute(nameof(GetTrainedByIdAsync), new { id = rdtReadDto.OfficerId }, rdtReadDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTrained(string id,RDTrainedUpdateDto rdtUpdateDto)
        {
            var rdtModelFromRepo = await _repository.GetTrainedByIdAsync(id);
            if (rdtModelFromRepo == null)
            {
                return NotFound();
            }

            // _mapper.Map(rdtUpdateDto, rdtModelFromRepo);
            var rdtToUpdate = _mapper.Map<RDTrained>(rdtUpdateDto);
            _repository.UpdateTrained(rdtModelFromRepo, rdtToUpdate);
            await _repository.SaveChangsAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTrained(string id)
        {
            var rdtModelFromRepo = await _repository.GetTrainedByIdAsync(id);
            if (rdtModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteTrained(rdtModelFromRepo);
            await _repository.SaveChangsAsync();
            return NoContent();
        }

        [HttpPatch("id")]
        public async Task<ActionResult> PartialUpdateTrained(string id, JsonPatchDocument<RDTrainedUpdateDto> patchDoc)
        {
            var rdtModelFromRepo = await _repository.GetTrainedByIdAsync(id);
            if (rdtModelFromRepo == null)
            {
                return NotFound();
            }

            var rdtToPatch = _mapper.Map<RDTrainedUpdateDto>(rdtModelFromRepo);
            patchDoc.ApplyTo(rdtToPatch, ModelState);
            if (!TryValidateModel(rdtToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(rdtToPatch, rdtModelFromRepo);
            await _repository.SaveChangsAsync();
            return NoContent();
        }
    }
}
