using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210028
{
    internal class PosisiKarakterGame
    {
        public enum KaraState { Jongkok, Berdiri, Tengkurap, Terbang};
        public enum Trigger { TombolW, TombolS, TombolX };

        class transition
        {
            public KaraState prevState;
            public KaraState nextState;
            public Trigger trigger;

            public transition(KaraState prevState, KaraState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions =
        {
            new transition(KaraState.Jongkok, KaraState.Berdiri, Trigger.TombolW),
            new transition(KaraState.Jongkok, KaraState.Tengkurap, Trigger.TombolS),
            new transition(KaraState.Berdiri, KaraState.Terbang, Trigger.TombolW),
            new transition(KaraState.Berdiri, KaraState.Jongkok, Trigger.TombolS),
            new transition(KaraState.Terbang, KaraState.Berdiri, Trigger.TombolS),
            new transition(KaraState.Terbang, KaraState.Jongkok, Trigger.TombolX),
            new transition(KaraState.Tengkurap, KaraState.Jongkok, Trigger.TombolW),
        };

        public KaraState currentState;

        public KaraState getNextState(KaraState prevState, Trigger trigger)
        {
            KaraState nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                {
                    nextState = transitions[i].nextState;
                }
            }
            return nextState;
        }

        public void activeTrigger(Trigger trigger)
        {
            KaraState nextState = getNextState(currentState, trigger);
            currentState = nextState;
        }
    }
}
