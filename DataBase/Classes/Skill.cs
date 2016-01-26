using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Skill
    {
        public Skill()
        {
            Id = Guid.NewGuid();
        }
        
        public Skill(string digimonId, SkillType type, string nameRus, string nameEng, string descriptionRus, 
            string descriptionEng, int mp,decimal ap, SkillSource skillSource = SkillSource.Native)
        {
            Id = Guid.NewGuid();
            DigimonId = digimonId;
            Type = type;
            NameRus = nameRus;
            NameEng = nameEng;
            DescriptionRus = descriptionRus;
            DescriptionEng = descriptionEng;
            MP = mp;
            AP = ap;
        }


        [NotMapped]
        public string DigimonId { get; set; }

        public Guid Id { get; set; }
        
        public virtual Digimon Digimon { get; set; }

        public SkillType Type { get; set; }

        public string NameRus { get; set; }

        public string NameEng { get; set; }

        public string DescriptionRus { get; set; }

        public string DescriptionEng { get; set; }

        public int MP { get; set; }

        public decimal AP { get; set; }

       

    }

    public enum SkillSource
    {
        Native = 0,
        Wild = 1,
        Wild1 = 2,
        Wild2 = 3,
        Wild3 = 4,
        Wild4 = 5,
        Wild5 = 6,
   
       
    }
    //    ������:
    //SkillSource.Wild ��� ����� ����������� ������ � ����� ���������.
    //SkillSource.Wild1 ��� ����� ����� �������� ������ ������� ���� ����� Gameshark.
    //SkillSource.Wild2 ��� ����� ����������� ������ � ����� � ����-������.
    //SkillSource.Wild3 ��� ����� ����������� ������ � ����� � ����-������.
    //SkillSource.Wild4 ��� ����� ����������� ������ � ����� � ����-������.
    //SkillSource.Wild5 ��� ����� ����������� ������ � ������ ������������� � ����-������.



//    SkillSource.Wild Only wild digimon have this move.
//    SkillSource.Wild1 You can unlock this move only using Gameshark.
//SkillSource.Wild2 Only Patch Domain boss have this move.
//SkillSource.Wild3 Only Mega Domain boss have this move.
//SkillSource.Wild4 Only Data Domain boss have this move.
//SkillSource.Wild5 Only wild MetalGreymon in a Patch Domain have this move.



    public enum SkillType
    {
        /// <summary>
        /// �����
        /// </summary>
        Attack,
        /// <summary>
        /// �����������
        /// </summary>
        CounterAttack,
        /// <summary>
        /// ����������
        /// </summary>
        Interrupt,
        /// <summary>
        /// ������
        /// </summary>
        Assist
    }
}