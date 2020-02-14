using _07_RepositoryPattern_Repository;
using _07_RepositoryPattern_Repository.contenttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_repositoryPattern_consoleUI.UI
{
    public class programUI
    {
        private readonly streaming_repository _streamingRepo = new streaming_repository();

        private IConsole _console;

        public programUI(IConsole console)
        {
            _console = console;
        }


        public void Run()
        {
            SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool basecase = true;
            while (basecase)
            {
                _console.Clear();

                _console.WriteLine("Select an option number:\n" +
                    "1. Display all streaming content\n" +
                    "2. Display all TV\n" +
                    "3. Display all Movies\n" +
                    "4. Add streaming content\n" +
                    "5. Update existing content\n" +
                    "6. Remove content\n" +
                    "7. Exit");

                string userinput = _console.ReadLine();
                userinput = userinput.Replace(" ", "");
                switch (userinput)
                {
                    case "1":
                        //show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //display all shows
                        break;
                    case "3":
                        //display all movies
                        break;
                    case "4":
                        //add content
                        AddNewStreamingContent();
                        break;
                    case "5":
                        //update content
                        UpdateContent();
                        break;
                    case "6":
                        //remove content
                        break;
                    case "7":
                        basecase = false;
                        break;
                    default:
                        _console.WriteLine($"{userinput} is not a valid input, please select from the option menu.");
                        break;
                }
            }

        }
        private void ShowAllContent()
        {
            _console.Clear();

            List<StreamingContent> directory = _streamingRepo.GetAllContent();

            foreach (StreamingContent content in directory)
            {
                _console.WriteLine($"Title: {content.Title} \n" +
                    $"Description: {content.Description}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Rating: {content.Rating}\n" +
                    $"Is Family Friendly {content.IsFamilyFriendly}\n" +
                    $"Stars: {content.QualityRating}\n" +
                    $"StreamingQuality {content.TypeOfStreamingQuality}\n" +
                    $"Language: {content.Language}\n");

            }
            _console.WriteLine("press any key to continue");
            _console.ReadKey();
            // get content

        }

        private void AddNewStreamingContent()
        {
            StreamingContent content = new StreamingContent();
            _console.WriteLine("Hello there, please enter a title");
            content.Title = _console.ReadLine();

            _console.WriteLine("Now, add a description");
            content.Description = _console.ReadLine();

            _console.WriteLine("What is the genre");
            content.Genre = _console.ReadLine();

            _console.WriteLine("What is the star rating?");
            content.QualityRating = Convert.ToInt32(_console.ReadLine());
            //content.StarRating = int.Parse(_console.ReadLine());

            _console.WriteLine("Select a Maturity rating (enter a value between 1 and 5)\n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG 13 \n" +
                "4) R \n" +
                "5) NC 17");

            string maturityString = _console.ReadLine();
            int ratingID = int.Parse(maturityString);
            content.Rating = (ContentRatings)ratingID;

            _console.WriteLine("Select a streaming Quality from below (choose a value between 1 and 5 \n" +
                "1) SD240 \n" +
                "2) SD480 \n" +
                "3) HD720 \n" +
                "4) HD1080 \n" +
                "5) UHD4k");
            string userInput = _console.ReadLine();
            switch (userInput)
            {
                case "1":
                    content.TypeOfStreamingQuality = StreamingQualityType.SD240;
                    break;
                case "2":
                    content.TypeOfStreamingQuality = StreamingQualityType.SD480;
                    break;
                case "3":
                    content.TypeOfStreamingQuality = StreamingQualityType.HD720;
                    break;
                case "4":
                    content.TypeOfStreamingQuality = StreamingQualityType.FHD1080;
                    break;
                case "5":
                    content.TypeOfStreamingQuality = StreamingQualityType.UHD4k;
                    break;
            }
            _console.WriteLine("Last step! What language is this content");
            content.Language = _console.ReadLine();
            _streamingRepo.AddContentToDirectory(content);
            _console.WriteLine("Your content has been added! Press any key to return to the main menu");
            _console.ReadKey();
        }
        private void UpdateContent()
        {
            _console.WriteLine("tell me what you want to change you little shit");
            string titleInput = _console.ReadLine();
            StreamingContent existingContent = _streamingRepo.GetContentbyTitle(titleInput);

            if (existingContent == null)
            {
                _console.WriteLine("there is no content with that title \n" +
                    "Press any key to continue...");
                _console.ReadKey();
            }
            else
            {
                StreamingContent oldcontent = new StreamingContent();
                _console.WriteLine("Hello there, please enter a title");
                oldcontent.Title = _console.ReadLine();

                _console.WriteLine("Now, add a description");
                oldcontent.Description = _console.ReadLine();

                _console.WriteLine("What is the genre");
                oldcontent.Genre = _console.ReadLine();

                _console.WriteLine("What is the star rating?");
                oldcontent.QualityRating = Convert.ToInt32(_console.ReadLine());
                //content.StarRating = int.Parse(_console.ReadLine());

                _console.WriteLine("Select a Maturity rating (enter a value between 1 and 5)\n" +
                    "1) G \n" +
                    "2) PG \n" +
                    "3) PG 13 \n" +
                    "4) R \n" +
                    "5) NC 17");

                string maturityString = _console.ReadLine();
                int ratingNumber = int.Parse(maturityString);
                existingContent.Rating = (ContentRatings)ratingNumber;

                _console.WriteLine("Select a streaming Quality from below (choose a value between 1 and 5 \n" +
                    "1) SD240 \n" +
                    "2) SD480 \n" +
                    "3) HD720 \n" +
                    "4) HD1080 \n" +
                    "5) UHD4k");
                string usersInput = _console.ReadLine();
                switch (usersInput)
                {
                    case "1":
                        existingContent.TypeOfStreamingQuality = StreamingQualityType.SD240;
                        break;
                    case "2":
                        existingContent.TypeOfStreamingQuality = StreamingQualityType.SD480;
                        break;
                    case "3":
                        existingContent.TypeOfStreamingQuality = StreamingQualityType.HD720;
                        break;
                    case "4":
                        existingContent.TypeOfStreamingQuality = StreamingQualityType.FHD1080;
                        break;
                    case "5":
                        existingContent.TypeOfStreamingQuality = StreamingQualityType.UHD4k;
                        break;
                }
                _console.WriteLine("Last step! What language is this content");
                existingContent.Language = _console.ReadLine();
                _console.WriteLine("Content has been changed, press any key to return to main menu");
                _console.ReadKey();
            }
        }

        private void SeedList()
        {
            StreamingContent toystory = new StreamingContent("Bromance", "toy story", 10, StreamingQualityType.FHD1080, "some good shit boi", "english mf do u speak it.", ContentRatings.PG);
            _streamingRepo.AddContentToDirectory(toystory);
            tv avatar = new tv("adventure", "Avatar the Last Airbender", 10, StreamingQualityType.FHD1080, "Aang goes hard in the paint", "English", ContentRatings.PG, new List<tv.Episode>());
            _streamingRepo.AddContentToDirectory(avatar);
            movie walkhard = new movie("drama", "Walk hard: the dewey cox story.", 11, StreamingQualityType.FHD1080, "The tragic tale of a boy what cut his brother in half with a machete.", "English", ContentRatings.R, 123.45);
            _streamingRepo.AddContentToDirectory(walkhard);
        }

    }
}

