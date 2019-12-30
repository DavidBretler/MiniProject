﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{

    public static class Cloning
    {//hosting unit order gestrequest
        public static BE.HostingUnit Clone(this BE.HostingUnit original)
        {
            BE.HostingUnit target = new BE.HostingUnit();
            target.setHostingUnitKey(original.getHostingUnitKey()) ;
            target.setOwner(original.getOwner());
            target.setHostingUnitName(original.getHostingUnitName());
            target.setNumOfRooms(original.getNumOfRooms());
            target.setNumOfBeds(  original.getNumOfBeds());
           
            target.setPool(original.getPool());
            target.setJacuzzi(original.getJacuzzi());
            target.setArea(original.getArea());
            target.setGarden(original.getGarden());
            target.setAirConditioner(original.getAirConditioner());
            target.setChildrensAttractions (original.getChildrensAttractions());
            target.setType (original.getType());
            target.sethikes(original.gethikes());
            target.setDiary(original.getDiary());    
            return target;
        }   
        public static Lecture Clone(this Lecture original)
        {
            Lecture target = new Lecture();
            target.id = original.id;
           
 return target;
        }
        //and so on for each entity…
    }
}
