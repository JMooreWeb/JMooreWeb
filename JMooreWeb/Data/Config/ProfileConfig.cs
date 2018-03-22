using JMooreWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JMooreWeb.Data.Config
{
	public class ProfileConfig : IEntityTypeConfiguration<Profile>
	{
		public void Configure(EntityTypeBuilder<Profile> builder)
		{
			builder.HasKey(e => e.Id);

			builder.Property(e => e.CreateDate);
			builder.ToTable("Profile");
		}
	}
}
