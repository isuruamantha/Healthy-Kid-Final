using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyKidNew
{
    public class viewList
    {
        

        public List<listItem> GetMyItems(String age)
        {
            

            if(age.Equals("3 Months")) { 
            List<listItem> myItemsList = new List<listItem>();
            myItemsList.Add(new listItem { Id = 1, MyAttribute = "Reacts to loud sounds" });
            myItemsList.Add(new listItem { Id = 2, MyAttribute = "Calms down or smiles when spoken to" });
            myItemsList.Add(new listItem { Id = 3, MyAttribute = "Recognizes your voice and calms down if crying" });
            myItemsList.Add(new listItem { Id = 4, MyAttribute = "When feeding, starts or stops sucking in response to sound" });
            myItemsList.Add(new listItem { Id = 5, MyAttribute = "Coos and makes pleasure sounds" });
            myItemsList.Add(new listItem { Id = 6, MyAttribute = "Has a special way of crying for different needs" });
            myItemsList.Add(new listItem { Id = 7, MyAttribute = "Smiles when he or she sees you" });
            return myItemsList;
            }

            if (age.Equals("4 to 6 Months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Follows sounds with his or her eyes" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Responds to changes in the tone of your voice" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Notices toys that make sounds" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Pays attention to music" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Babbles in a speech-like way and uses many different sounds, including sounds that begin with p, b, and m" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Laughs" });
                myItemsList.Add(new listItem { Id = 7, MyAttribute = "Babbles when excited or unhappy" });
                myItemsList.Add(new listItem { Id = 8, MyAttribute = "Makes gurgling sounds when alone or playing with you" });
                return myItemsList;
            }

            if (age.Equals("7 months to one year"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Enjoys playing peek-a-boo and pat-a-cake" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Turns and looks in the direction of sounds" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Listens when spoken to" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Understands words for common items such as “cup,” “shoe,” or “juice”" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Responds to requests (“Come here”)" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Babbles using long and short groups of sounds (“tata, upup, bibibi”)" });
                myItemsList.Add(new listItem { Id = 7, MyAttribute = "Babbles to get and keep attention" });
                myItemsList.Add(new listItem { Id = 8, MyAttribute = "Communicates using gestures such as waving or holding up arms" });
                myItemsList.Add(new listItem { Id = 9, MyAttribute = "Imitates different speech sounds" });
                myItemsList.Add(new listItem { Id = 10, MyAttribute = "Has one or two words (“Hi,” “dog,” “Dada,” or “Mama”) by first birthday" });
                return myItemsList;
            }

            if (age.Equals("1 to 2 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Knows a few parts of the body and can point to them when asked" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Follows simple commands (“Roll the ball”) and understands simple questions (“Where’s your shoe?”)" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Enjoys simple stories, songs, and rhymes" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Points to pictures, when named, in books" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Acquires new words on a regular basis" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Uses some one- or two-word questions (“Where kitty?” or “Go bye-bye?”)" });
                myItemsList.Add(new listItem { Id = 7, MyAttribute = "Puts two words together (“More cookie”)" });
                myItemsList.Add(new listItem { Id = 8, MyAttribute = "Uses many different consonant sounds at the beginning of words" });
                return myItemsList;
            }

            if (age.Equals("2 to 3 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Has a word for almost everything" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Uses two- or three-word phrases to talk about and ask for things" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Uses k, g, f, t, d, and n sounds" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Speaks in a way that is understood by family members and friends" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Names objects to ask for them or to direct attention to them" });
                
                return myItemsList;
            }

            if (age.Equals("3 to 4 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Hears you when you call from another room" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Hears the television or radio at the same sound level as other family members" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Answers simple “Who?” “What?” “Where?” and “Why?” questions" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Talks about activities at daycare, preschool, or friends’ homes" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Uses sentences with four or more words" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Speaks easily without having to repeat syllables or words" });
                
                return myItemsList;
            }

            if (age.Equals("4 to 5 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Pays attention to a short story and answers simple questions about it" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Hears and understands most of what is said at home and in school" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Uses sentences that give many details" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Tells stories that stay on topic" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Communicates easily with other children and adults" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Says most sounds correctly except for a few (l, s, r, v, z, ch, sh, and th)" });
                myItemsList.Add(new listItem { Id = 7, MyAttribute = "Names some letters and numbers" });
                myItemsList.Add(new listItem { Id = 8, MyAttribute = "Uses adult grammar" });
                return myItemsList;
            }

            return null;
        }


        public List<listItem> GetMyItemsVision(String age)
        {


            if (age.Equals("1 to 3 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Looks at faces and pictures with contrasting black and white images" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Can follow an object up to 90 degrees" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Watches parent closely" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Tears begin to work" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Begins to be able to see an object as one image" });
                myItemsList.Add(new listItem { Id = 6, MyAttribute = "Looks at hands" });
                myItemsList.Add(new listItem { Id = 7, MyAttribute = "Follows light, faces, and objects" });
                return myItemsList;
            }

            if (age.Equals("4 to 5 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Beginning to reach hands to objects, may bat at hanging object with hands" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Can stare at block" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Recognizes bottle" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Will look at self in mirror" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Will look at own hand" });
                
                return myItemsList;
            }

            if (age.Equals("5 to 7 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Can pick up a toy that is dropped" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Will turn head to see an object" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Likes certain colors" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Will touch image of self in mirror" });
                
                return myItemsList;
            }

            if (age.Equals("11 to 12 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Can stare at small objects" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Plays peek-a-boo" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Can watch objects that are moving fast" });
                
                return myItemsList;
            }

            if (age.Equals("12 to 14 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Able to place shapes in proper holes" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Becomes interested in pictures" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Recognizes familiar objects and pictures in books, may point to some objects when asked,Where is the...? " });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Points and gestures for objects and actions" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Recognizes own face in mirror" });

                return myItemsList;
            }

            if (age.Equals("18 to 24 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Able to focus on objects near and far" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Scribbles with crayon or pencil, may imitate drawing straight line or circle" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Can point to body parts (nose, hair, and eyes) when asked" });
               

                return myItemsList;
            }

            if (age.Equals("36 to 38 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Can copy shapes" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Names colors" });
                
                return myItemsList;
            }

            if (age.Equals("4 to 5 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Recognizes and recites the alphabet" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Ready to begin reading" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Has complete depth perception" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Uses scissors" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Can name coins and money" });
                
                return myItemsList;
            }
            return null;
        }

        public List<listItem> GetMyItemsSocial(String age)
        {


            if (age.Equals("3 to 4 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Infant communication by crying" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Smiles spontaneously to mother's face, voice, smile" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Watches parent closelyResponds to person-to-person contact with adults and children" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "enjoys being cuddled" });
                
                return myItemsList;
            }

            if (age.Equals("4 to 9 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Enjoys being near people and played with" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "no longer smiles indiscriminately" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Responds gaily to play interactions with others" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Cries, smiles, kicks, coos, laughs to attract social attention" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Responds differently to strangers (stranger anxiety-8 mos.)" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Shouts for attention (8 mos.) rejects confinement" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Cries if other child cries" });
                return myItemsList;
            }

            if (age.Equals("10 to 12 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Pays attention to his/her own name" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Recognizes different tones of voice and responds" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Able to interpret the emotional expression of familiar adults" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Copies simple actions of others" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Recognizes himself as an individual apart from mother" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Learning to cooperate; shows guilt at wrongdoing" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Actively seeks to maintain interactions with adult" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Tries to alter mother's plans through persuasion or protest" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Displays separation anxiety when apart from mother" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Developing a sense of humor" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Teases and tests parental limits" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Can demonstrate affection" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Discriminates positive and negative attention" });
                return myItemsList;
            }

            if (age.Equals("1 - 2 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Recognizes self in mirror or picture and refers to self by name" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Beginning to become independent" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Cooperates by helping to put things away" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "May become angry if activities are interrupted" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Responds to simple commands by adult" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Begins to realize that can't have everything own way" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Social relationships with other children are awkward" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "May hit, bite or fight over a toy" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Engages in social laughter" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Shows anger through aggressive behavior" });
                return myItemsList;
            }

            if (age.Equals("2 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Differential facial expression reflect emotional range" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Defends own possessions but is beginning to share" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Asks for wants " });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Knows gender identity" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Participates in simple group activity - singing, dancing" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Little interaction with other children" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Mother continues to be very important to child" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Sometimes makes special friend by age 3" });

                return myItemsList;
            }

            if (age.Equals("3 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Friends becoming more interesting than adults" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Shares toys, takes turns with assistance" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Uses I, me, you" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Beginning to learn to take responsibility" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Shows affection for younger siblings" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Associative group play begins" });

                return myItemsList;
            }

            if (age.Equals("4 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Plays and interacts with other children" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Improving in turn-taking and cooperating" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Spurred on by rivalry in activity" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Understands social problem solving" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Shows interest in exploring sex differences" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Developing self-responsibility; enjoys doing things for self" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Plays outside with little supervision; likes to be trusted" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Sense of property is developing" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Still home and mother-oriented" });

                return myItemsList;
            }

            if (age.Equals("5 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Wants to do what is expected" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Respects reasonable authority" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Willing to play with most other children in the class" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Engages with other children in cooperative play; fair play" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Engages with other children in role assignments" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Chooses own friends; friendships change rapidly" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "One or two best friends of same sex" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Awareness of sex roles begins" });

                return myItemsList;
            }
            return null;
        }

        public List<listItem> GetMyItemsMotor(String age)
        {


            if (age.Equals("0 to 6 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Rolls over front to back and back to front" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Sits with support and then independently" });
                

                return myItemsList;
            }

            if (age.Equals("6 to 12 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Crawls forwards on belly" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Assumes a seated position unaided" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Creeps on hands and knees" });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Transitions into different positions: sitting, all fours, lying on tummy" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Pulls self to stand" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Walks while holding onto furniture" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Takes 2-3 steps without support" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Rolls a ball in imitation of an adult" });
                return myItemsList;
            }

            if (age.Equals("18 months"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Sits, crawls, walks" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Still has wide gait but walking/running is less clumsy" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Pushes against a ball (does not actually kick it)" });
                
                return myItemsList;
            }

            if (age.Equals("2 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Walks smoothly and turns corners" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Begins running" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Is able to pull or carry a toy while walking" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Climbs onto/down from furniture without assistance" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Walks up and down steps with support" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Picks up toys from the floor without falling over" });
                
                return myItemsList;
            }

            if (age.Equals("3 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Imitates standing on one foot" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Imitates simple bilateral movements of limbs (e.g., arms up together)" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Climbs jungle gym and ladders " });
                myItemsList.Add(new listItem { Id = 4, MyAttribute = "Pedals on tricycle" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Walks up/down stairs alternating feet" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Jumps in place with two feet together" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Able to walk on tip toes" });
                myItemsList.Add(new listItem { Id = 5, MyAttribute = "Catches using body" });

                return myItemsList;
            }

            if (age.Equals("4 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Stands on one foot for up to 5 seconds" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Kicks a ball forwards" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Throws a ball overarm" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Catches a ball that has been bounced" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Runs around obstacles" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Able to walk on a line" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Able to hop on one foot" });
                myItemsList.Add(new listItem { Id = 3, MyAttribute = "Jumps over an object and lands with both feet together" });
                return myItemsList;
            }

            if (age.Equals("5 years"))
            {
                List<listItem> myItemsList = new List<listItem>();
                myItemsList.Add(new listItem { Id = 1, MyAttribute = "Able to walk up stairs while holding an object" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Walks backward toe-heel" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Jumps forward 10 times without falling" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Skips forwards after demonstration" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Hangs from a bar for at least 5 seconds" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Steps forward with leg on same side as throwing arm when throwing a ball" });
                myItemsList.Add(new listItem { Id = 2, MyAttribute = "Catches a small ball using hands only" });
                

                return myItemsList;
            }

            
            return null;
        }

    }
}
