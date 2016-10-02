using System.Collections.Generic;

namespace MusicStore.Dtos
{
    public class NewRentalDto
    {
        public byte CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}