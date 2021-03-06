// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// Details of a template image.
    /// </summary>
    public partial class TemplateImage
    {
        private string _id;
        
        /// <summary>
        /// Optional. The unique identifier for the image.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The friendly name for the image.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int _numberOfLinkedCollections;
        
        /// <summary>
        /// Optional. The number of collections using this image.
        /// </summary>
        public int NumberOfLinkedCollections
        {
            get { return this._numberOfLinkedCollections; }
            set { this._numberOfLinkedCollections = value; }
        }
        
        private OfficeType _officeType;
        
        /// <summary>
        /// Optional. For platform template images, the type of Office which is
        /// included in the image.
        /// </summary>
        public OfficeType OfficeType
        {
            get { return this._officeType; }
            set { this._officeType = value; }
        }
        
        private string _pathOnClient;
        
        /// <summary>
        /// Optional. The path of the image on the client.
        /// </summary>
        public string PathOnClient
        {
            get { return this._pathOnClient; }
            set { this._pathOnClient = value; }
        }
        
        private IList<string> _regionList;
        
        /// <summary>
        /// Optional. The list of regions where the image can be used.
        /// </summary>
        public IList<string> RegionList
        {
            get { return this._regionList; }
            set { this._regionList = value; }
        }
        
        private string _sas;
        
        /// <summary>
        /// Optional. The image upload SAS key.
        /// </summary>
        public string Sas
        {
            get { return this._sas; }
            set { this._sas = value; }
        }
        
        private DateTime _sasExpiry;
        
        /// <summary>
        /// Optional. The time when the image upload SAS key will expire.
        /// </summary>
        public DateTime SasExpiry
        {
            get { return this._sasExpiry; }
            set { this._sasExpiry = value; }
        }
        
        private long _size;
        
        /// <summary>
        /// Optional. The image size in bytes.
        /// </summary>
        public long Size
        {
            get { return this._size; }
            set { this._size = value; }
        }
        
        private TemplateImageStatus _status;
        
        /// <summary>
        /// Optional. The image status.
        /// </summary>
        public TemplateImageStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private bool _trialOnly;
        
        /// <summary>
        /// Optional. A TrialOnly platform template image may be used only
        /// during a subscription's RemoteApp trial period. Once billing is
        /// activated, a collection using a TrialOnly image will be
        /// permanently disabled.
        /// </summary>
        public bool TrialOnly
        {
            get { return this._trialOnly; }
            set { this._trialOnly = value; }
        }
        
        private TemplateImageType _type;
        
        /// <summary>
        /// Optional. The type of the template image.
        /// </summary>
        public TemplateImageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private DateTime _uploadCompleteTime;
        
        /// <summary>
        /// Optional. The time when the image upload was completed.
        /// </summary>
        public DateTime UploadCompleteTime
        {
            get { return this._uploadCompleteTime; }
            set { this._uploadCompleteTime = value; }
        }
        
        private DateTime _uploadSetupTime;
        
        /// <summary>
        /// Optional. The time when the image upload parameters were set.
        /// </summary>
        public DateTime UploadSetupTime
        {
            get { return this._uploadSetupTime; }
            set { this._uploadSetupTime = value; }
        }
        
        private DateTime _uploadStartTime;
        
        /// <summary>
        /// Optional. The time when the image upload was started.
        /// </summary>
        public DateTime UploadStartTime
        {
            get { return this._uploadStartTime; }
            set { this._uploadStartTime = value; }
        }
        
        private string _uri;
        
        /// <summary>
        /// Optional. The image upload endpoint URI.
        /// </summary>
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TemplateImage class.
        /// </summary>
        public TemplateImage()
        {
            this.RegionList = new LazyList<string>();
        }
    }
}
