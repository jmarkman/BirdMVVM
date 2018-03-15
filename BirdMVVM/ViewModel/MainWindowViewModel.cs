using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace BirdMVVM
{
    class MainWindowViewModel
    {
        public List<Bird> BirdSource { get; }

        public MainWindowViewModel()
        {
            BirdSource = new List<Bird>
            {
                new Bird("Northern Mockingbird", "http://cdn.audubon.org/cdn/farfuture/sQpaLtrt_VKJpOrDojOAbYZTfLpONNYRPFRRa0tiytM/mtime:1422549549/sites/default/files/Northern_Mockingbird_w27-10-007_l.jpg"),
                new Bird("American Robin", "http://cdn.audubon.org/cdn/farfuture/EFwVSD5ZjCri9ztCiVIPsEmnM5Nb70uOocoxR3tN17Q/mtime:1422549546/sites/default/files/American_Robin_m17-69-001_l_0.jpg"),
                new Bird("Cerulean Warbler", "http://cdn.audubon.org/cdn/farfuture/7JGNHjAYHmJCEsMB0B7BL6eo96XHhnoAvP_C08GhI0E/mtime:1422549586/sites/default/files/Cerulean_Warbler_s52-13-131_l.jpg"),
                new Bird("Northern Cardinal", "http://cdn.audubon.org/cdn/farfuture/8jMt8z8DxX8TeqllMI0iS2gsMdn8mob3fZzS7nB-S-8/mtime:1422549824/sites/default/files/Northern_Cardinal_b57-4-155_l_1.jpg"),
                new Bird("Common Sandpiper", "http://cdn.audubon.org/cdn/farfuture/pXcUkJMF2c_lw3uCqSaTnPEi4Ffg-IHsglGjNRxD5Jg/mtime:1422550528/sites/default/files/Common_Sandpiper_h42-3-082_l_1.jpg"),
                new Bird("House Sparrow", "http://cdn.audubon.org/cdn/farfuture/YKzWlbmkuvKOB_XmvizcCPUwkrqYdlyo1Kpe8qkHPnk/mtime:1422549946/sites/default/files/House_Sparrow_m17-30-225_l_1.jpg")
            };
        }
    }
}
