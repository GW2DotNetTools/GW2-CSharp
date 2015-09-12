using GW2Sharp.v2.unauthenticated.miscellaneous.worlds.enums;

namespace GW2Sharp.v2.unauthenticated.miscellaneous.worlds
{
    public class World   
    {
        /// <summary>
        /// Represents a single world from the v2/worlds Endpoint.
        /// </summary>
        /// <param name="id">The world Id.</param>
        /// <param name="name">The world name.</param>
        /// <param name="population">The world population level. One of: Low, Medium, High, VeryHigh, Full</param>
        public World(int id, string name, Population population)
        {
            Id = id;
            Name = name;
            Population = population;
        }

        /// <summary>
        /// Returns the Id of this world.
        /// </summary>
        public int Id { get; private set; }
        
        /// <summary>
        /// Returns the Name of this world.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Returns the Population of this world.
        /// </summary>
        public Population Population { get; private set; }

        /// <summary>
        /// Returns the Region of this world.
        /// <para>The first digit of the id indicates the world's region. 1 is North America, 2 is Europe.</para>
        /// </summary>
        public Region Region
        {
            get 
            {
                int regionId = Id / 1000;
                return (Region)regionId;
            }
        }

        /// <summary>
        /// Returns the Language of this world.
        /// <para>The second digit of the id currently correlates with the world's assigned language: 1 means French, 2 means German, and 3 means Spanish.</para>
        /// </summary>
        public Language Language 
        {
            get 
            {
                int languageId = (Id / 100) % 10;
                return (Language)languageId;
            }
        }
    }
}
