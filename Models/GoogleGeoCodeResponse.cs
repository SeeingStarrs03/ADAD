﻿using System.ComponentModel.DataAnnotations.Schema;

namespace adad.Models;
//This class is only used for the serialization of inbound lat long data using the Google Maps API.  Do not use or disturb.

public class GoogleGeoCodeResponse
{

    public String status;
    public results[] result;

    public GoogleGeoCodeResponse()
    {
    }

    public class results
    {
        public String formatted_address;
        public geometry geometry;
        public String[] types;
        public address_component[] address_components;
    }

    public class geometry
    {
        public bounds bounds;
        public String location_type;
        public location location;
        public bounds viewport;
    }

    public class bounds
    {

        public location northeast;
        public location southwest;
    }

    public class location
    {
        public String lat;
        public String lng;
    }

    public class address_component
    {
        public String long_name;
        public String short_name;
        public String[] types;
    }
}