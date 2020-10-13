﻿using Automobiliu_skelbimu_portalas.Contracts;
using Automobiliu_skelbimu_portalas.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automobiliu_skelbimu_portalas.Repository
{
    public class GearBoxRepository : IGearBoxRepository
    {
        private readonly ApplicationDbContext _db;
        public GearBoxRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> Create(GearBox entity)
        {
            await _db.GearBoxes.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(GearBox entity)
        {
            _db.GearBoxes.Remove(entity);
            return await Save();
        }

        public async Task<bool> Edit(GearBox entity)
        {
            _db.GearBoxes.Update(entity);
            return await Save();
        }

        public async Task<List<GearBox>> FindAll()
        {
            var damages = await _db.GearBoxes.ToListAsync();
            return damages;
        }

        public async Task<GearBox> FindById(int id)
        {
            var damage = await _db.GearBoxes.FindAsync(id);
            return damage;
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(GearBox entity)
        {
            _db.GearBoxes.Update(entity);
            return await Save();
        }
    }
}
