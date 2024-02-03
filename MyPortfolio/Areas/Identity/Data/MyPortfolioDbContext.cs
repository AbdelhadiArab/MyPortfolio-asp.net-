﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPortfolio.Areas.Identity.Data;

namespace MyPortfolio.Areas.Identity.Data;

public class MyPortfolioDbContext : IdentityDbContext<MyPortfolioUser>
{
    public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new MyPortfolioUserConfiguration());
    }
}


public class MyPortfolioUserConfiguration : IEntityTypeConfiguration<MyPortfolioUser>
{
    public void Configure(EntityTypeBuilder<MyPortfolioUser> builder)
    {
        builder.Property(x => x.FristName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);

    }
}