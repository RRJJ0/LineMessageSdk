using Line.Model.Receive.Event;
using Line.Model.Receive.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Line.Model.Receive
{
    public interface IMessageReceiver
    {
        void OnTextMessage(MessageEvent ev, TextMessage message);

        void OnImageMessage(MessageEvent ev, ImageMessage message);

        void OnVideoMessage(MessageEvent ev, VideoMessage message);

        void OnAudioMessage(MessageEvent ev, VideoMessage message);

        void OnFileMessage(MessageEvent ev, FileMessage message);

        void OnLocationMessage(MessageEvent ev, LocationMessage message);

        void OnStickerMessage(MessageEvent ev, StickerMessage message);

        void OnUnsend(UnsendEvent ev);

        void OnFollow(FollowEvent ev);

        void OnUnFollow(Event.Event ev);

        void OnJoin(Event.Event ev);

        void OnLeave(Event.Event ev);

        void OnMemberJoin(MemberJoinEvent ev);

        void OnMemberLeave(MemberLeftEvent ev);

        void OnPoseBack(PostBackEvent ev);

        void OnVideoEnd(VideoEvent ev);

        void OnBeacon(BeaconEvent ev);

        void OnAccountLink(AccountLinkEvent ev);

        string GetChannelSercet();
    }
}
