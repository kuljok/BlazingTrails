using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazingTrails.Api.Persistence.Entities;

public class TrailConfig: IEntityTypeConfiguration<Trail>
{
    public void Configure(EntityTypeBuilder<Trail> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Location).IsRequired();
        builder.Property(x => x.TimeInMinutes).IsRequired();
        builder.Property(x => x.Length).IsRequired();
        builder.Property(x => x.Owner).IsRequired();
    }
}