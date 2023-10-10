using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace TP3_
{
    internal class Photo
    {
        private string _path;
        private Uri _source;
        PhotoMetadata _phmetadata;

        public Photo(string path)
        {
            _path = path;
            _source = null;
            if(_path != "")
            {
                _source = new Uri(_path);
            }

            _phmetadata = new PhotoMetadata(_source);
        }

        public override string ToString()
        {
            return _source.ToString();
        }

        public string Source
        {
            get
            {
                return _path;
            }
        }
        public PhotoMetadata Metadata 
        {
            get 
            {
                return _phmetadata; 
            } 
        }
        public class PhotoMetadata
        {
            private BitmapMetadata _metadata;

            public PhotoMetadata(Uri imageUri)
            {
                BitmapFrame frame = BitmapFrame.Create(imageUri, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                _metadata = (BitmapMetadata)frame.Metadata;
            }

            public DateTime? DateTaken
            {
                get
                {
                    Object val = _metadata.DateTaken;
                    if (val != null)
                    {
                        return Convert.ToDateTime(_metadata.DateTaken.ToString());
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public string Title
            {
                get
                {
                    Object val = _metadata.Title;
                    if (val != null)
                    {
                        return _metadata.Title.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            public string Camera
            {
                get
                {
                    Object val = _metadata.CameraModel;
                    if (val != null)
                    {
                        return _metadata.CameraModel.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            public string Application
            {
                get
                {
                    Object val = _metadata.ApplicationName;
                    if (val != null)
                    {
                        return _metadata.ApplicationName.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            //Methodes supp
            private decimal ParseUnsignedRational(ulong exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0xFFFFFFFF00000000L) >> 32);
            }
            private decimal ParseSignedRational(long exifValue)
            {
                return (decimal)(exifValue & 0xFFFFFFFFL) / (decimal)((exifValue & 0x7FFFFFFF00000000L) >> 32);
            }
            private object QueryMetadata(string query)
            {
                if (_metadata.ContainsQuery(query))
                    return _metadata.GetQuery(query);
                else
                    return null;
            }


            public string IsoSpeed
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=34855}"); ;
                    if (val != null)
                    {
                        string v = val.ToString();
                        return v;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public string Ouverture
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint=33437}"); ;
                    if (val != null)
                    {
                        string v = ParseUnsignedRational((ulong)val).ToString();
                        return v;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public string Focale
            {
                get
                {
                    Object val = QueryMetadata("/app1/ifd/exif/subifd:{uint= 37386}"); ;
                    if (val != null)
                    {
                        string v = ParseUnsignedRational((ulong)val).ToString();
                        return v;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
