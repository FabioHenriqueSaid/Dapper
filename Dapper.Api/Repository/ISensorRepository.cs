using Dapper.Api.Domain;
using System.Collections.Generic;

namespace Dapper.Api.Repository
{
    public interface ISensorRepository
    {
        public IEnumerable<Sensor> ListAll();
        public int Insert(long step);
    }
}