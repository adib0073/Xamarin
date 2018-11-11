using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangLibrary
{
    public class Character
    {
        private readonly BigBangLib[] characters;
        private readonly int lastIndex;
        int currentindex = 0;
        public Character()
        {
            characters = InitCharacter();
            lastIndex = characters.Length - 1;  
        }

        private BigBangLib[] InitCharacter()
        {
            var initCharacters = new BigBangLib[] {
             new BigBangLib()
             {
                 myTitle="Sheldon",
                 myContent="Sheldon Lee Cooper from the Big Bang Theory",
                 myImage="sheldon"

             },
             new BigBangLib()
             {
                 myTitle="Leonard",
                 myContent="Leaonard Hofstadter from the Big Bang Theory",
                 myImage="leonard"

             },
             new BigBangLib()
             {
                 myTitle="Raj",
                 myContent="Rajesh Koothrapalli from the Big Bang Theory",
                 myImage="raj"

             },
             new BigBangLib()
             {
                 myTitle="Howard",
                 myContent="Howard Wolowitz from the Big Bang Theory",
                 myImage="howard"

             }

            };
            return initCharacters;
        }
        public void MoveFirst()
        {
            currentindex = 0;
        }
        public void MovePrev()
        {
            if(currentindex>0)
            currentindex --;
        }
        public void MoveNext()
        {
            if (currentindex < characters.Length -1)
                currentindex++;
        }
        public Boolean CanMovePrev
        {
            get { return currentindex > 0; }
        }
        public Boolean CanMoveNext
        {
            get { return currentindex < lastIndex; }
        }
        public BigBangLib Current
        {
            get { return characters[currentindex]; }
        }
    }
}
