using System;

namespace PersonalityDecoderApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReveal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string rashi = ddlRashi.SelectedValue.Trim();

            int nameScore = 0;
            foreach (char c in name)
            {
                nameScore += c;
            }

            int index = (nameScore + rashi[0]) % 3;

            string trait = "", strength = "", weakness = "", pattern = "";

            switch (rashi)
            {
                case "Aries":
                    trait = new[] { "Bold", "Energetic", "Action-driven" }[index];
                    strength = new[] { "Leadership", "Confidence", "Initiative" }[index];
                    weakness = new[] { "Impatience", "Short temper", "Restlessness" }[index];
                    pattern = new[] {
                "You start fast but lose interest midway",
                "You act quickly without overthinking",
                "You chase excitement over stability"
            }[index];
                    break;

                case "Taurus":
                    trait = new[] { "Stable", "Grounded", "Reliable" }[index];
                    strength = new[] { "Consistency", "Loyalty", "Patience" }[index];
                    weakness = new[] { "Stubbornness", "Resistance to change", "Attachment" }[index];
                    pattern = new[] {
                "You prefer comfort over risk",
                "You hold on to things longer than needed",
                "You move slow but steady"
            }[index];
                    break;

                case "Gemini":
                    trait = new[] { "Curious", "Expressive", "Versatile" }[index];
                    strength = new[] { "Communication", "Adaptability", "Quick thinking" }[index];
                    weakness = new[] { "Overthinking", "Inconsistency", "Indecisiveness" }[index];
                    pattern = new[] {
                "Your mind rarely rests",
                "You switch interests frequently",
                "You think more than you act"
            }[index];
                    break;

                case "Cancer":
                    trait = new[] { "Emotional", "Caring", "Protective" }[index];
                    strength = new[] { "Empathy", "Loyalty", "Intuition" }[index];
                    weakness = new[] { "Mood swings", "Over-attachment", "Sensitivity" }[index];
                    pattern = new[] {
                "You feel deeply but hide it",
                "You protect people you love strongly",
                "Your emotions guide your decisions"
            }[index];
                    break;

                case "Leo":
                    trait = new[] { "Confident", "Charismatic", "Bold" }[index];
                    strength = new[] { "Leadership", "Creativity", "Presence" }[index];
                    weakness = new[] { "Ego", "Dominance", "Attention-seeking" }[index];
                    pattern = new[] {
                "You like being noticed",
                "You lead naturally in groups",
                "You seek appreciation for efforts"
            }[index];
                    break;

                case "Virgo":
                    trait = new[] { "Practical", "Detail-oriented", "Analytical" }[index];
                    strength = new[] { "Organization", "Focus", "Problem-solving" }[index];
                    weakness = new[] { "Overthinking", "Perfectionism", "Self-criticism" }[index];
                    pattern = new[] {
                "You notice small details others miss",
                "You aim for perfection always",
                "You analyze everything deeply"
            }[index];
                    break;

                case "Libra":
                    trait = new[] { "Balanced", "Charming", "Peaceful" }[index];
                    strength = new[] { "Diplomacy", "Fairness", "Social skills" }[index];
                    weakness = new[] { "Indecisiveness", "Avoiding conflict", "People-pleasing" }[index];
                    pattern = new[] {
                "You seek harmony everywhere",
                "You avoid difficult decisions",
                "You value relationships deeply"
            }[index];
                    break;

                case "Scorpio":
                    trait = new[] { "Intense", "Focused", "Mysterious" }[index];
                    strength = new[] { "Determination", "Depth", "Resilience" }[index];
                    weakness = new[] { "Jealousy", "Control issues", "Secrecy" }[index];
                    pattern = new[] {
                "You feel things intensely",
                "You trust very selectively",
                "You transform through struggles"
            }[index];
                    break;

                case "Sagittarius":
                    trait = new[] { "Adventurous", "Optimistic", "Free-spirited" }[index];
                    strength = new[] { "Exploration", "Honesty", "Vision" }[index];
                    weakness = new[] { "Restlessness", "Impulsiveness", "Lack of focus" }[index];
                    pattern = new[] {
                "You seek freedom over stability",
                "You love exploring new ideas",
                "You dislike restrictions"
            }[index];
                    break;

                case "Capricorn":
                    trait = new[] { "Disciplined", "Serious", "Ambitious" }[index];
                    strength = new[] { "Hard work", "Patience", "Responsibility" }[index];
                    weakness = new[] { "Rigidity", "Work obsession", "Emotional distance" }[index];
                    pattern = new[] {
                "You prioritize long-term success",
                "You stay focused on goals",
                "You carry responsibilities strongly"
            }[index];
                    break;

                case "Aquarius":
                    trait = new[] { "Innovative", "Independent", "Visionary" }[index];
                    strength = new[] { "Creativity", "Original thinking", "Open-mindedness" }[index];
                    weakness = new[] { "Detachment", "Unpredictability", "Rebellion" }[index];
                    pattern = new[] {
                "You think differently from others",
                "You value independence deeply",
                "You question traditional paths"
            }[index];
                    break;

                case "Pisces":
                    trait = new[] { "Dreamy", "Intuitive", "Creative" }[index];
                    strength = new[] { "Imagination", "Empathy", "Spiritual depth" }[index];
                    weakness = new[] { "Escapism", "Over-sensitivity", "Confusion" }[index];
                    pattern = new[] {
                "You live in imagination often",
                "You absorb others’ emotions",
                "You seek deeper meaning in life"
            }[index];
                    break;
            }

            lblResult.Text =
                "<div style='font-size:16px; margin-bottom:10px;'>" +
                "<b>" + name + "</b>, here is your personality insight:</div>" +

                "<div><b>✨ Trait:</b> " + trait + "</div>" +
                "<div><b>💪 Strength:</b> " + strength + "</div>" +
                "<div><b>⚠️ Weakness:</b> " + weakness + "</div>" +
                "<div><b>🔍 Hidden Pattern:</b> " + pattern + "</div>";
        }
    }
}