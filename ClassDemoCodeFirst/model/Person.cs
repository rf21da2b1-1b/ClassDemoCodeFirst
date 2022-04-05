using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoCodeFirst.model
{
    public class Person
    {
        private int _id;
        private string _navn;
        private string _adr;
        private int? _ancinitet;

        public Person()
        {
        }

        public Person(int id, string navn, string adr, int ancinitet)
        {
            _id = id;
            _navn = navn;
            _adr = adr;
            _ancinitet = ancinitet;
        }

        // hjælp til entity framework => annotations
        [Key]
        [Required]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [Required]
        [StringLength(25)]
        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        [StringLength(50)]
        public string Adr
        {
            get => _adr;
            set => _adr = value;
        }

        public int? Ancinitet
        {
            get => _ancinitet;
            set => _ancinitet = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Adr)}: {Adr}, {nameof(Ancinitet)}: {Ancinitet}";
        }
    }
}
