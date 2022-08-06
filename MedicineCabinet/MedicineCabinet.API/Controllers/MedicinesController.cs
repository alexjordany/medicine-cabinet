using MediatR;
using MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;
using MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicineDetail;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesList;
using Microsoft.AspNetCore.Mvc;

namespace MedicineCabinet.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MedicinesController : ControllerBase
{
    private readonly IMediator _mediator;

    public MedicinesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("CreateMedicine",Name = "CreateMedicine")]
    public async Task<ActionResult<CreateMedicineCommandResponse>> Create([FromBody] CreateMedicineCommand createMedicineCommand)
    {
        var response = await _mediator.Send(createMedicineCommand);
        return Ok(response);
    }

    [HttpPut("UpdateMedicine",Name = "UpdateMedicine")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateMedicineCommand updateMedicineCommand)
    {
        var dtos = await _mediator.Send(updateMedicineCommand);
        return Ok(dtos);
    }

    [HttpGet("all", Name = "GetAllMedicines")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<MedicineListVM>>> GetAllMedicines()
    {
        var dtos = await _mediator.Send(new GetMedicinesListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id:int}", Name = "GetMedicineById")]
    public async Task<ActionResult<MedicineDetailVM>> GetMedicineById(int id)
    {
        var getMedicineDetailQuery = new GetMedicineDetailQuery() { Id = id };
        return Ok(await _mediator.Send(getMedicineDetailQuery));
    }

    [HttpGet("GetByName/{name}", Name = "GetMedicinesByName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<MedicineByNameVM>>> GetMedicinesByName(string name)
    {
        var dtos = await _mediator.Send(new GetMedicineByNameQuery { Name = name });
        if (dtos.Any())
            return Ok(dtos);

        return NotFound();
    }
}

