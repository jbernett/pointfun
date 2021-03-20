using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using backend.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;
using System.Threading.Tasks;

namespace backend.Utilities
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PointsAndSlidesDb(
                serviceProvider.GetRequiredService<DbContextOptions<PointsAndSlidesDb>>()))
            {
                if (context.Scans.Any())
                {
                    return;
                }

                Scan scanOne = new Scan {Guid = new Guid("bdf70d60-d58a-4498-a427-4cae60964bc3") };

                Slice sliceOne = new Slice { Guid = new Guid("ead5222d-701e-4d4f-9c30-46fd60c4fc17"), Scan = scanOne };
                Location locationSixSliceOne = new Location { slice = sliceOne, x = 30M, y = 30M, Guid = Guid.NewGuid(), tail = null };
                Location locationFiveSliceOne = new Location { slice = sliceOne, x = 60M, y = 30M, Guid = Guid.NewGuid(), tail = locationSixSliceOne  };
                Location locationFourSliceOne = new Location { slice = sliceOne, x = 110M, y = 50M, Guid = Guid.NewGuid(), tail = locationFiveSliceOne  };
                Location locationThreeSliceOne = new Location { slice = sliceOne, x = 100M, y = 80M, Guid = Guid.NewGuid() }, tail = locationFourSliceOne ;
                Location locationTwoSliceOne = new Location { slice = sliceOne, x = 10M, y = 50M, Guid = Guid.NewGuid(), tail = locationThreeSliceOne };
                Location locationOneSliceOne = new Location { slice = sliceOne, x = 30M, y = 30M, Guid = Guid.NewGuid(), tail = locationTwoSliceOne };

                Slice sliceTwo = new Slice { Guid = new Guid("11d9b038-57b1-4562-9fb7-78c372e5ad29"), Scan = scanOne };
                Location locationSixSliceTwo = new Location { slice = sliceTwo, x = 35M, y = 35M, Guid = Guid.NewGuid(), tail = null };
                Location locationFiveSliceTwo = new Location { slice = sliceTwo, x = 65M, y = 35M, Guid = Guid.NewGuid(), tail = locationSixSliceTwo  };
                Location locationFourSliceTwo = new Location { slice = sliceTwo, x = 115M, y = 55M, Guid = Guid.NewGuid(), tail = locationFiveSliceTwo  };
                Location locationThreeSliceTwo = new Location { slice = sliceTwo, x = 105M, y = 85M, Guid = Guid.NewGuid(), tail = locationFourSliceTwo };
                Location locationTwoSliceTwo = new Location { slice = sliceTwo, x = 15M, y = 55M, Guid = Guid.NewGuid(), tail = locationThreeSliceTwo };
                Location locationOneSliceTwo = new Location { slice = sliceTwo, x = 35M, y = 35M, Guid = Guid.NewGuid(), tail = locationTwoSliceTwo };

                Slice sliceThree = new Slice { Guid = new Guid("d66f0af1-fa6c-47ba-b71c-9963a2328604"), Scan = scanOne };
                Location locationSixSliceThree = new Location { slice = sliceThree, x = 45M, y = 45M, Guid = Guid.NewGuid(), tail = null };
                Location locationFiveSliceThree = new Location { slice = sliceThree, x = 75M, y = 45M, Guid = Guid.NewGuid(), tail = locationSixSliceThree  };
                Location locationFourSliceThree = new Location { slice = sliceThree, x = 125M, y = 65M, Guid = Guid.NewGuid(), tail = locationFiveSliceThree  };
                Location locationThreeSliceThree = new Location { slice = sliceThree, x = 115M, y = 95M, Guid = Guid.NewGuid(), tail = locationFourSliceThree };
                Location locationTwoSliceThree = new Location { slice = sliceThree, x = 25M, y = 65M, Guid = Guid.NewGuid(), tail = locationThreeSliceThree };
                Location locationOneSliceThree = new Location { slice = sliceThree, x = 45M, y = 45M, Guid = Guid.NewGuid(), tail = locationTwoSliceThree };

                context.Scans.Add(scanOne);                            

                context.Slices.AddRange(sliceOne, sliceTwo, sliceThree);

                context.Locations.AddRange(
                 locationSixSliceOne,
                 locationFiveSliceOne,
                 locationFourSliceOne,
                 locationThreeSliceOne,
                 locationTwoSliceOne,
                 locationOneSliceOne,
                 locationSixSliceTwo,
                 locationFiveSliceTwo,
                 locationFourSliceTwo,
                 locationThreeSliceTwo,
                 locationTwoSliceTwo,
                 locationOneSliceTwo,
                 locationSixSliceThree,
                 locationFiveSliceThree,
                 locationFourSliceThree,
                 locationThreeSliceThree,
                 locationTwoSliceThree,
                 locationOneSliceThree
                );

                context.SaveChanges();
            }
        }
    }
}