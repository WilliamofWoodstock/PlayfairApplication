using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairApplication
{
    internal static class Alphabet
    {
        static readonly char[] english = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
        /// <summary>
        /// Array where each spot is a lowercase letter of the English alphabet
        /// </summary>
        public static char[] English { get { return english; } }

        static readonly char[] german = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','ä','ö','ü','ß' };
        /// <summary>
        /// Array where each spot is a lowercase letter of the German alphabet
        /// </summary>
        public static char[] German { get { return german; } }

        static readonly char[] polish = { 'a','ą','b','c','ć','d','e','ę','f','g','h','i','j','k','l','ł','m','n','ń','o','ó','p','q','r','s','ś','t','u','v','w','x','y','z','ź','ż' };
        /// <summary>
        /// Array where each spot is a lowercase letter of the Polish alphabet
        /// </summary>
        public static char[] Polish { get { return polish; } }

        static readonly char[] bulgarian = { 'a','б','b','г','д','e','ж','з','и','й','к','л','м','н','o','п','p','с','т','у','ф','х','ц','ч','ш','щ','ъ','ь','ю','я' };
        /// <summary>
        /// Array where each spot is a lowercase letter of the Bulgarian alphabet
        /// </summary>
        public static char[] Bulgarian { get { return bulgarian; } }

        static readonly char[] russian;
        /// <summary>
        /// Array where each spot is a lowercase letter of the Russian alphabet.
        /// </summary>
        public static char[] Russian { get { return russian; } }
    }
}
