using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2Lib
{
    public interface IMarriageOffice
    {
        void AddContract(Contract contract);
        void AddContract(Groom groom, Bride bride, DateTime date);
    }

    public class MarriageOffice : IMarriageOffice
    {
        public IList<Groom> Grooms { get; } = new List<Groom>();
        public IList<Bride> Brides { get; } = new List<Bride>();
        public IList<Contract> Contracts { get; } = new List<Contract>();
        public IList<Photographer> Photographers { get; } = new List<Photographer>();

        public void AddContract(Contract contract)
        {
            Grooms.Add(contract.Groom);
            Brides.Add(contract.Bride);
            Contracts.Add(contract);
        }

        public void AddContract(Groom groom, Bride bride, DateTime date)
        {
            var contract = new Contract(groom, bride, date);
            AddContract(contract);
        }
    }
}