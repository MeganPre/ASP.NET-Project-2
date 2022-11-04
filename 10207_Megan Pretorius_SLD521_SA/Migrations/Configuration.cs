namespace _10207_Megan_Pretorius_SLD521_SA.Migrations
{
    using _10207_Megan_Pretorius_SLD521_SA.Models.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_10207_Megan_Pretorius_SLD521_SA.Models.Data.PaperDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_10207_Megan_Pretorius_SLD521_SA.Models.Data.PaperDbContext context)
        {
            context.papers.AddOrUpdate(
                s => s.PaperTitle,
                new Paper
                {
                    PaperId = 1,
                    PaperTitle = "Evaluating Deep Sequential Knowladge Tracing Models for Predicting Student Performance",
                    PaperAbstract = "One of the key priorities in all instructional enviroments is to ensure that students recognise" +
                    "their learning mechanisms and pathways. Knowledge Tracing is the task of modelling student" +
                    "Knowledge from their learning history, is an important problem in the field of AI in education and " +
                    "has numerous applications in the development of interactive and addaptive learning technologies",
                    PaperDateSubmitted = DateTime.Now,
                    PaperAuthor = "mary",
                    UserEmail = "mary@gmail.com",
                    TopicId = 1,
                    TopicName = "Data Science"
                });

            context.papers.AddOrUpdate(
            new Paper
                {
                    PaperId = 2,
                    PaperTitle = "An analysis on the adoption of nternet of Things (IoT) in the monitoring of diabetes",
                    PaperAbstract = "The Internet of things (IoT) is revolutionizing several industries with unprecedented possibilities" +
                    " and opportunities. One of the industries that has a critical direct impact on humans, is the healthcare industry. " +
                    "While IoT technologies can be seen in medical supply chains within the healthcare sector, however, IoT technologies " +
                    "are still not widely adopted in other areas and services within the healthcare sector",
                    PaperDateSubmitted = DateTime.Now,
                    UserEmail = "thabo@gmail.com",
                    TopicId = 2,
                    TopicName = "Internet of Things"
                });

            context.topics.AddOrUpdate(s => s.Details,
                new Topic { Details = "Data Science" },
                new Topic { Details = "Education" },
                new Topic { Details = "Human-Computer Interaction" },
                new Topic { Details = "Internet of Things" });
        }

        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //  to avoid creating duplicate seed data.
    }
}

