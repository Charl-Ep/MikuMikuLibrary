﻿using System.Collections.Generic;
using System.ComponentModel;
using MikuMikuLibrary.Objects;
using MikuMikuLibrary.Objects.Extra;
using MikuMikuModel.Nodes.Collections;

namespace MikuMikuModel.Nodes.Objects
{
    public class SkinNode : Node<Skin>
    {
        public override NodeFlags Flags => NodeFlags.Add;

        [DisplayName( "Ex data blocks" )]
        public List<Block> Blocks =>
            GetProperty<List<Block>>();

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
            Nodes.Add( new ListNode<BoneInfo>( "Bones", Data.Bones, x => x.Name ) );
        }

        protected override void SynchronizeCore()
        {
        }

        public SkinNode( string name, Skin data ) : base( name, data )
        {
        }
    }
}