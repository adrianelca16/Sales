
using Modelos.Entities;

namespace Api.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if(!_context.Countries.Any()) 
            {
                _context.Countries.Add(new Country { 
                    Name = "Venezuela",
                    States = new List<State>
                    {
                        new State {
                            Name="Miranda",
                            Cities = new List<City>
                            {
                                new City {Name="Caracas"},
                                new City {Name="Guarenas"},
                                new City {Name="Guatire"}
                            }
                        },
                        new State {
                            Name="Merida",
                            Cities = new List<City>
                            {
                                new City {Name="Vijia"},
                                new City {Name="Tovar"},
                                new City {Name="Merida"}
                            }
                        },
                        new State {
                            Name="Amazonas",
                            Cities = new List<City>
                            {
                                new City {Name="La esmeralda"},
                                new City {Name="Sa Juan"},
                                new City {Name="Puerto Ayacucho"}
                            }
                        }
                    }
                });
                _context.Countries.Add(new Country { 
                    Name = "Colombia",
                    States = new List<State>
                    {
                        new State {
                            Name="Bogota",
                            Cities = new List<City>
                            {
                                new City {Name="Santa Fe"},
                                new City {Name="San Cristobal"},
                                new City {Name="Usme"}
                            }
                        },
                        new State {
                            Name="Antioquia",
                            Cities = new List<City>
                            {
                                new City {Name="Medellin"},
                                new City {Name="Barbosa"},
                                new City {Name="Bello"}
                            }
                        },
                        new State {
                            Name="Norte de Santander",
                            Cities = new List<City>
                            {
                                new City {Name="Bucarasica"},
                                new City {Name="El Tarra"},
                                new City {Name="Sardinata"}
                            }
                        }
                    }
                });
                _context.Countries.Add(new Country { 
                    Name = "Brasil",
                    States = new List<State>
                    {
                        new State {
                            Name="Rio de janaeiro",
                            Cities = new List<City>
                            {
                                new City {Name="Lagoa"},
                                new City {Name="Leme"},
                                new City {Name="Botafogo"}
                            }
                        },
                        new State {
                            Name="Bahía",
                            Cities = new List<City>
                            {
                                new City {Name="Feria de Santana"},
                                new City {Name="Victoria de la Conquista"},
                                new City {Name="Juazeiro"}
                            }
                        },
                        new State {
                            Name="Paraná",
                            Cities = new List<City>
                            {
                                new City {Name="Curitiba"},
                                new City {Name="Londrina"},
                                new City {Name="Maringá"}
                            }
                        }
                    }
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
