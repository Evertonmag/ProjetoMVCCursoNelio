﻿using Microsoft.EntityFrameworkCore;
using ProjetoMVCCusoNelio.Data;
using ProjetoMVCCusoNelio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVCCusoNelio.Services
{
    public class SalesRecordService
    {
        private readonly ProjetoMVCCusoNelioContext _context;

        public SalesRecordService(ProjetoMVCCusoNelioContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return (await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync())
                .GroupBy(x => x.Seller.Department)
                .ToList();
            //return await result
            //    .Include(x => x.Seller)
            //    .Include(x => x.Seller.Department)
            //    .OrderByDescending(x => x.Date)
            //    .GroupBy(x => x.Seller.Department)
            //    .ToListAsync();
        }
    }
}
