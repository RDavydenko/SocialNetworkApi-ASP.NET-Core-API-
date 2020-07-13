﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetworkApi.Models;

namespace SocialNetworkApi.Controllers
{
	/* ЗАМЕТКИ:
	 * Контроллер обязательно должен разрешать тип json с помощью атрибута:
	 * [Produces("application/json")]
	 * Такой тип данных должен быть указан в запросе (contentType)
	 * Пример: contentType: 'application/json; charset=utf-8'
	 * Поэтому данные запроса должны заворачиваться в анонимный тип и отправляться с помощью
	 * JSON.stringify() - в javaScript
	 * Данные ответа представляют собой json формат, поэтому в ajax-запросе:
	 * dataType: "json"
	 * 
	 * !!! ВАЖНО !!!
	 * Данные в параметрах метода идут с атрибутом [FromBody] и обернуты в ViewModel
	 * Поля ViewModel должны соответствовать с названиями отправленных полей из ajax-запроса
	 * Если не оборачивать во ViewModel, то будет ошибка в валидации
	 * 
	 * О РЕГИСТРОЗАВИСИМОСТИ: 
	 * (При отправке данных можно не соблюдать регистр) Id == id
	 * (ПРИ ПОЛУЧЕНИИ И ОБРАБОТКЕ ВАЖЕН РЕГИСТР) Id != id
	 * 
	*/

	[Authorize]
	[Produces("application/json")]
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{		

		public MessagesController()
		{
			
		}

		[HttpGet]
		public IActionResult Get()
		{
			return new JsonResult("Liza");
		}

		// GET api/messages
		//[HttpGet]
		//public IActionResult Get()
		//{
		//	return new JsonResult(_repository.Entities.Select(x => new { Id = x.Id, Text = x.Text }), new JsonSerializerOptions
		//	{
		//		IgnoreNullValues = true,
		//		WriteIndented = true,
		//	});
		//}

		//// GET api/messages/{id}
		//[HttpGet]
		//[Route("{id}")]
		//public IActionResult GetById([FromRoute] int id)
		//{
		//	var message = _repository.Entities.FirstOrDefault(m => m.Id == id);
		//	if (message == null)
		//	{
		//		return NotFound();
		//	}

		//	return new JsonResult(message, new JsonSerializerOptions
		//	{
		//		IgnoreNullValues = true,
		//		WriteIndented = true,
		//	});
		//}

		//// POST api/messages
		//[HttpPost]
		//public IActionResult Create([FromBody] Message model) // Ожидается поле с именем "text"
		//{
		//	var text = model.Text;
		//	if (string.IsNullOrWhiteSpace(text))
		//	{
		//		return Problem();
		//	}
		//	var newMessage = new Message { Id = _repository.NextId, Text = text, SendingTime = DateTime.Now };
		//	_repository.Entities.Add(newMessage);
		//	_repository.NextId++;

		//	return new JsonResult(newMessage, new JsonSerializerOptions
		//	{
		//		IgnoreNullValues = true,
		//		WriteIndented = true,
		//	});
		//}

		//// PUT api/messages/{id}
		//[HttpPut]
		//[Route("{id}")]
		//public IActionResult EditById([FromRoute] int id, [FromBody] Message model) // Ожидается поле с именем "text"
		//{
		//	var message = _repository.Entities.Where(m => m.Id == id).FirstOrDefault();
		//	var text = model.Text;
		//	if (message == null)
		//		return NotFound();

		//	if (string.IsNullOrWhiteSpace(text))
		//	{
		//		return Problem();
		//	}
		//	message.Text = text;
		//	return new JsonResult(message, new JsonSerializerOptions
		//	{
		//		IgnoreNullValues = true,
		//		WriteIndented = true,
		//	});
		//}

		//// DELETE api/messages/{id}
		//[HttpDelete]
		//[Route("{id}")]
		//public IActionResult DeleteById([FromRoute] int id)
		//{
		//	var message = _repository.Entities.Where(m => m.Id == id).FirstOrDefault();
		//	if (message == null)
		//		return NotFound();

		//	_repository.Entities.Remove(message);
		//	return Ok();
		//}
	}
}
