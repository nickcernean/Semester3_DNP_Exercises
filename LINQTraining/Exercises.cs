using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using DataGenerator.Generator;
using LINQTraining.DataAccess;
using LINQTraining.Generator;
using Microsoft.EntityFrameworkCore;
using Models;
using NUnit.Framework;
using static LINQTraining.PrintUtil.Printer;

namespace LINQTraining
{
    [TestFixture]
    public class Exercises
    {
        /**
         * Intro text
         * In this exercise you are supposed to solve all questions using only the ctx.Families entry point to the database.
         * That means if you use e.g. ctx.Set<Child>()... you are taking an unintended shortcut.
         *
         * All questions can be answered with one statement. Though, if you're stuck you may find it easier to break it down
         * into multiple consecutive statements.
         *
         * Again, you have access to the PrettyPrint method. In this case however, it's a bit limited, because it cannot print
         * out nested objects. E.g. a Family have Adults, but that will not be printed out in a neat way.
         *
         * All questions have the correct answer above them in a comment
         */
        protected FamilyContext ctx;

        [SetUp]
        public virtual void Setup()
        {
            ctx = new FamilyContext();
        }

        /*
         [Test]
          public virtual void CreateAndSeed()
          {
              IList<Family> families = new FamilyGenerator().GenerateFamilies(500);
              string famSerialized = JsonSerializer.Serialize(families, new JsonSerializerOptions
              {
                  WriteIndented = true
              });
              DBSeeder.Seed(families);
          }*/

        // example
        [Test]
        public virtual void NumberOfAdults()
        {
            List<Adult> adults = ctx.Families.SelectMany(family => family.Adults).ToList();
            PrettyPrint(adults);
            int numOfAdults = adults.Count();
            Console.WriteLine(numOfAdults);
        }

        // example
        [Test]
        public virtual void DisplayRedHairedAdultsBetween37And53()
        {
            List<Adult> adults = ctx.Families.SelectMany(family => family.Adults).Where(adult =>
                adult.HairColor.Equals("Red") &&
                adult.Age >= 37 &&
                adult.Age <= 53
            ).ToList();
            PrettyPrint(adults);
        }


        // answer: 5
        [Test]
        public virtual void HowManyFamiliesLiveAt()
        {
            // street "Abby Park Street"
            var result = ctx.Families.Count(s => s.StreetName.Contains("Abby Park Street"));
            Console.WriteLine("HowManyFamiliesLiveAt Abby Park Street: " + result);
        }


        // answer 151
        [Test]
        public virtual void HowManyFamiliesHaveOneParent()
        {
            // we are looking for the number families, which have exactly one parent.

            var result = ctx.Families.Where(s => s.Adults.Count == 1);
            Console.WriteLine("HowManyFamiliesHaveOneParent: " + result.Count());
        }

        // answer: 123
        [Test]
        public virtual void HowManyFamiliesLiveInNumberThreeOrFive()
        {
            // no matter which street, just focus on house number
            var result = ctx.Families.Count(s => s.HouseNumber == 3 || s.HouseNumber == 5);
            Console.WriteLine("HowManyFamiliesLiveInNumberThreeOrFive: " + result);
        }


        // answer: 94
        [Test]
        public virtual void HowManyFamiliesHaveADog()
        {
            // one or more dogs
            var result = ctx.Families.Count(s => s.Pets.Any(n => n.Species.Equals("Dog")));
            Console.WriteLine("HowManyFamiliesHaveADog: " + result);
        }

        // answer: 18
        [Test]
        public virtual void HowManyFamiliesHaveCatAndDog()
        {
            // one or more of either. But at least one dog, and at least one cat
            var result = ctx.Families.Count(s =>
                s.Pets.Any(n => n.Species.Equals("Dog")) && s.Pets.Any(n => n.Species.Equals("Cat")));
            Console.WriteLine("HowManyFamiliesHaveCatAndDog: " + result);
        }


        // answer 125
        [Test]
        public virtual void HowManyFamiliesHave3Children()
        {
            // exactly 3 children
            var result = ctx.Families.Count(s => s.Children.Count == 3);
            Console.WriteLine("HowManyFamiliesHave3Children: " + result);
        }

        // answer: 175
        [Test]
        public virtual void How_Many_Families_Have_Gay_Parents()
        {
            // looking for families with two parents of the same sex
            // this one is pretty tough in one query, if you don't all ToList() before the end.
            var result = ctx.Families.Where(family => family.Adults.Count == 2).Where(family =>
                family.Adults.Count(adults => adults.Sex.Equals(family.Adults.First().Sex)) == 2);
            Console.WriteLine("How_Many_Families_Have_Gay_Parents: " + result.Count());
        }


        // answer 21
        [Test]
        public virtual void How_Many_Families_Have_An_Adult_With_Red_Hair()
        {
            // count the number of families with at least one adult with red hair.
            var result = ctx.Families.Count(family => family.Adults.Any(adults => adults.HairColor.Equals("Red")));
            Console.WriteLine("How_Many_Families_Have_An_Adult_With_Red_Hair: " + result);
        }


        // answer: 26
        [Test]
        public virtual void How_Many_Families_Have_2_Pets()
        {
            // Exactly 2 pets. Doesn't matter what type of pet. Ignore the children's pets for this one.
            var result = ctx.Families.Count(family => family.Pets.Count == 2);
            Console.WriteLine("How_Many_Families_Have_2_Pets: " + result);
        }


        // answer: 81
        [Test]
        public virtual void How_Many_Families_Have_A_Child_Playing_Soccer()
        {
            // at least one child.
            var result = ctx.Families.Count(family =>
                family.Children.Any(children =>
                    children.Interests.Any(childInterest => childInterest.Type.Equals("Soccer"))));
            Console.WriteLine("How_Many_Families_Have_A_Child_Playing_Soccer: " + result);
        }

        // answer: 355
        [Test]
        public virtual void How_Many_Families_Have_Adult_And_Child_With_Black_Hair()
        {
            // count number of families where at least one adult and one child have black hair
            var result = ctx.Families.Where(family => family.Adults.Any(adults => adults.HairColor.Equals("Black")))
                .Where(family => family.Children.Any(children => children.HairColor.Equals("Black"))).ToList();
            Console.WriteLine("How_Many_Families_Have_Adult_And_Child_With_Black_Hair: " + result.Count());
        }


        // answer: 47
        [Test]
        public virtual void How_Many_Families_Have_A_Child_With_Black_Hair_Playing_Ultimate()
        {
            // count number of families where at least one child has black hair and plays ultimate
            var result = ctx.Families.Count(family => family.Children.Any(children =>
                children.HairColor.Equals("Black") &&
                children.Interests.Any(interest => interest.Type.Equals("Ultimate"))));
            Console.WriteLine("How_Many_Families_Have_A_Child_With_Black_Hair_Playing_Ultimate: " + result);
        }


        // answer: 172
        [Test]
        public virtual void HowManyFamiliesHaveTwoAdultsWithSameHairColor()
        {
            var result = ctx.Families.Count(family =>
                family.Adults.Count == 2 &&
                family.Adults.Count(adult => adult.HairColor.Equals(family.Adults.First().HairColor)) == 2);
            Console.WriteLine("HowManyFamiliesHaveTwoAdultsWithSameHairColor: " + result);
        }

        // answer: 90
        [Test]
        public virtual void HowManyFamiliesHaveAChildWithAHamster()
        {
            var result =
                ctx.Families.Count(family =>
                    family.Children.Any(children => children.Pets.Any(pets => pets.Species.Equals("Hamster"))));
            Console.WriteLine("HowManyFamiliesHaveAChildWithAHamster: " + result);
        }


        // Answer: 5
        [Test]
        public virtual void HowManyChildrenAreInterestedInBothSoccerAndBarbies()
        {
            var result = ctx.Families.SelectMany(family => family.Children).Count(child =>
                child.Interests.Any(interest => interest.Type.Equals("Soccer")) &&
                child.Interests.Any(interest => interest.Type.Equals("Barbie")));
            Console.WriteLine("HowManyChildrenAreInterestedInBothSoccerAndBarbies: " + result);
        }


        // answer 157
        [Test]
        public virtual void HowManyChildrenAreOfHeightBetween95And112()
        {
            var result = ctx.Families.SelectMany(family => family.Children)
                .Count(child => child.Height >= 95 && child.Height <= 112);
            Console.WriteLine("HowManyChildrenAreOfHeightBetween95And112: " + result);
        }
    }
}