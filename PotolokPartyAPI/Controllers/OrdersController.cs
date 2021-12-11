using Microsoft.AspNetCore.Mvc;
using PotolokPartyAPI.Models;
using PotolokPartyAPI.Service;

namespace PotolokPartyAPI.Controllers
{
    #region snippetErrorCode
    public enum ErrorCode
    {
        ItemNameAndNotesRequired,
        ItemIDInUse,
        RecordNotFound,
        CouldNotCreateItem,
        CouldNotUpdateItem,
        CouldNotDeleteItem
    }
    #endregion

    #region snippetDI
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IRepository _repository;

        public OrdersController(IRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region snippet
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.All);
        }
        #endregion

        #region snippetCreate
        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            try
            {
                if (order == null || !ModelState.IsValid)
                {
                    return BadRequest(ErrorCode.ItemNameAndNotesRequired.ToString());
                }
                bool itemExists = _repository.DoesItemExist(order.Id);
                if (itemExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, ErrorCode.ItemIDInUse.ToString());
                }
                _repository.Insert(order);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotCreateItem.ToString());
            }
            return Ok(order);
        }
        #endregion

        #region snippetEdit
        [HttpPut]
        public IActionResult Edit([FromBody] Order order)
        {
            try
            {
                if (order == null || !ModelState.IsValid)
                {
                    return BadRequest(ErrorCode.ItemNameAndNotesRequired.ToString());
                }
                var existingItem = _repository.Find(order.Id);
                if (existingItem == null)
                {
                    return NotFound(ErrorCode.RecordNotFound.ToString());
                }
                _repository.Update(order);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotUpdateItem.ToString());
            }
            return NoContent();
        }
        #endregion

        #region snippetDelete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var item = _repository.Find(id);
                if (item == null)
                {
                    return NotFound(ErrorCode.RecordNotFound.ToString());
                }
                _repository.Delete(id);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotDeleteItem.ToString());
            }
            return NoContent();
        }
        #endregion
    }
}

