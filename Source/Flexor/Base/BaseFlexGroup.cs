using System;
using System.Collections.Generic;
using System.Text;

namespace Flexor.Base
{
    public abstract class BaseFlexGroup : BaseFlexComponent
    {
        private Direction direction = Direction.Horizontal;
        private GroupAlignment groupAlignment = GroupAlignment.Start;
        private ItemAlignment itemAlignment = ItemAlignment.Stretch;
        private bool isWrap;

        public Direction Direction
        {
            get => direction;
            set
            {
                direction = value;
                StateHasChanged();
            }
        }

        public GroupAlignment GroupAlignment
        {
            get => groupAlignment;
            set
            {
                groupAlignment = value;
                StateHasChanged();
            }
        }

        public ItemAlignment ItemAlignment
        {
            get => itemAlignment;
            set
            {
                itemAlignment = value;
                StateHasChanged();
            }
        }

        public bool IsWrap
        {
            get => isWrap;
            set
            {
                isWrap = value;
                StateHasChanged();
            }
        }

    }
}
