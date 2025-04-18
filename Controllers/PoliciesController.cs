﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BP_Proyecto.Models;
using Microsoft.IdentityModel.Tokens;
using Igor.Gateway.Dtos.Policies;
using Microsoft.CodeAnalysis.Elfie.Extensions;

namespace BP_Proyecto.Controllers
{
    public class PoliciesController : Controller
    {
        private readonly BPProyectoContext _context;

        public PoliciesController(BPProyectoContext context)
        {
            _context = context;
        }

        // GET: Policies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Policy.ToListAsync());
        }

        // GET: Policies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policy
                .FirstOrDefaultAsync(m => m.PolicyNumber == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // GET: Policies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Policies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PolicyNumber,PolicyType,CoverageAmount,ExpirationDate,IssueDate,Coverage,PolicyStatus,Premium,PolicyPeriod,InclusionDate,InsuranceCompany,ClientId")] Policy policy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(policy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(policy);
        }

        public async Task<IActionResult> Search(string buscar)
        {
            var policies = from Policy in _context.Policy
                        select Policy;

            if (!String.IsNullOrEmpty(buscar))
            {
                policies = policies.Where(s => s.PolicyNumber!.Contains(buscar) || s.InsuranceCompany!.Contains(buscar));      
            }

            return View(await policies.ToListAsync());
        }

        // GET: Policies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policy.FindAsync(id);
            if (policy == null)
            {
                return NotFound();
            }
            return View(policy);
        }

        // POST: Policies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PolicyNumber,PolicyType,CoverageAmount,ExpirationDate,IssueDate,Coverage,PolicyStatus,Premium,PolicyPeriod,InclusionDate,InsuranceCompany,ClientId")] Policy policy)
        {
            if (id != policy.PolicyNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyExists(policy.PolicyNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(policy);
        }

        // GET: Policies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policy = await _context.Policy
                .FirstOrDefaultAsync(m => m.PolicyNumber == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // POST: Policies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var policy = await _context.Policy.FindAsync(id);
            if (policy != null)
            {
                _context.Policy.Remove(policy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyExists(string id)
        {
            return _context.Policy.Any(e => e.PolicyNumber == id);
        }
    }
}
