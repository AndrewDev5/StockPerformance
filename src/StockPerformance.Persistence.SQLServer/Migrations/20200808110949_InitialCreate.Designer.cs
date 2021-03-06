// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockPerformance.Persistence.SQLServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200808110949_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockPerformance.Domain.Entities.Candle", b =>
                {
                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("AdjustedClose")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Close")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("High")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Low")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Open")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("Volume")
                        .HasColumnType("bigint");

                    b.HasKey("Timestamp", "Symbol");

                    b.ToTable("Candles");
                });
#pragma warning restore 612, 618
        }
    }
}
