using Moq;
using NUnit.Framework;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;
using Storm.InterviewTest.Hearthstone.Tests.Specification;

namespace Storm.InterviewTest.Hearthstone.Tests.Mapping
{
    [Category("Mapping")]
    public abstract class MappingCardsContext : ContextSpecification
    {
        protected Mock<IHearthstoneCardCache> _cache;

        protected override void SharedContext()
        {
            _cache = CreateDependency<IHearthstoneCardCache>();
            _cache.Setup(s => s.FindAll<HeroCard>()).Returns(new[]
            {
                new HeroCard("HERO1")
                {
                    Name = "My Hero Priest",
                    PlayerClass = "Priest",
                },
                new HeroCard("HERO2")
                {
                    Name = "My Hero Mage",
                    PlayerClass = "Mage",
                },
            });

            AutoMapperProfiles.RegisterProfiles(_cache.Object);
        }
    }
}