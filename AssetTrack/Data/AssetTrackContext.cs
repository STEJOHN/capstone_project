#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssetTrack.Models;

namespace AssetTrack.Data
{
    public class AssetTrackContext : DbContext
    {
        public AssetTrackContext (DbContextOptions<AssetTrackContext> options)
            : base(options)
        {
        }

        public DbSet<AssetTrack.Models.Asset> Asset { get; set; }
    }
}
