using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InkCraft.Data;
using System;
using System.Linq;

namespace InkCraft.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InkCraftContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<InkCraftContext>>()))
            {
                // Look for any papers.
                if (context.Paper.Any())
                {
                    return;   // DB has been seeded
                }

                context.Paper.AddRange(
                    new Paper
                    {
                        PaperType = "Glossy Paper",
                        Description = "Smooth and shiny surface that enhances color vibrancy.",
                        Quantity = 100,
                        Price = 12.99M
                    },
                    new Paper
                    {
                        PaperType = "Matte Paper",
                        Description = "Non-shiny surface that reduces glare and reflections.",
                        Quantity = 200,
                        Price = 10.99M
                    },
                    new Paper
                    {
                        PaperType = "Recycled Paper",
                        Description = "Eco-friendly option with a rougher texture.",
                        Quantity = 150,
                        Price = 8.99M
                    },
                    new Paper
                    {
                        PaperType = "Cardstock",
                        Description = "Thick and durable paper ideal for business cards.",
                        Quantity = 300,
                        Price = 15.99M
                    },
                    new Paper
                    {
                        PaperType = "Textured Paper",
                        Description = "Paper with a tactile surface, often with patterns or fibers.",
                        Quantity = 120,
                        Price = 14.99M
                    },
                    new Paper
                    {
                        PaperType = "Coated Paper",
                        Description = "Smooth surface with good ink holdout, available in matte or glossy finishes. Ideal for high-quality printing.",
                        Quantity = 250,
                        Price = 11.99M
                    },
                    new Paper
                    {
                        PaperType = "Uncoated Paper",
                        Description = "Smooth and affordable paper for everyday printing, suitable for text-heavy documents.",
                        Quantity = 400,
                        Price = 7.99M
                    },
                    new Paper
                    {
                        PaperType = "Kraft Paper",
                        Description = "Strong and recyclable paper with a natural look, often used for paper bags.",
                        Quantity = 500,
                        Price = 9.99M
                    },
                    new Paper
                    {
                        PaperType = "Crepe Paper",
                        Description = "Lightweight and textured paper with a crinkled appearance, ideal for crafts and decorations.",
                        Quantity = 300,
                        Price = 6.99M
                    },
                    new Paper
                    {
                        PaperType = "Tissue Paper",
                        Description = "Thin and lightweight paper used for wrapping and decorative purposes.",
                        Quantity = 600,
                        Price = 4.99M
                    }
                
                
                );
                context.SaveChanges();
            }
        }
    }
}
