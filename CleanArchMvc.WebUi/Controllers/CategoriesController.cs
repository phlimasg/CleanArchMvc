﻿using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchMvc.WebUi.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO categoryDTO)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.CreateAsync(categoryDTO);
                return RedirectToAction("Index");
            }
            return View(categoryDTO);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            
            var categoryDTO = await _categoryService.GetByIdAsync(id);
            
            if(categoryDTO == null) return NotFound();
            
            return View(categoryDTO);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryDTO categoryDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.UpdateAsync(categoryDTO);
                }
                catch (Exception)
                {

                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(categoryDTO);
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();

            var categoryDTO = await _categoryService.GetByIdAsync(id);

            if (categoryDTO == null) return NotFound();

            var delete = _categoryService.RemoveAsync(categoryDTO.Id);

            return View(categoryDTO);
        }
    }
}
