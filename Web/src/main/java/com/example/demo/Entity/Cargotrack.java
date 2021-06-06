//package com.example.demo.Entity;
//
//import org.dom4j.Branch;
//import javax.persistence.*;
//import javax.persistence.Column;
//import javax.persistence.Entity;
//import javax.persistence.Table;
//
//@Entity
//@Table(name = "at")
//public class Cargotrack {
//    @Id
//    @GeneratedValue(strategy = GenerationType.AUTO)
//    @Column(name = "Branch_ID")
//    Long BranchID;
//    @Column(name = "Branch_Location")
//    String Branch_Location;
//
//    @Column(name = "Cargo_Id")
//    Long ID;
//    @Column(name = "Received")
//    String Date;
//
//    public void setBranchID(Long branchID) {
//        BranchID = branchID;
//    }
//
//    public void setBranch_Location(String branch_Location) {
//        Branch_Location = branch_Location;
//    }
//
//    public void setID(Long ID) {
//        this.ID = ID;
//    }
//
//    public void setDate(String date) {
//        Date = date;
//    }
//
//    public Long getBranchID() {
//        return BranchID;
//    }
//
//    public String getBranch_Location() {
//        return Branch_Location;
//    }
//
//    public Long getID() {
//        return ID;
//    }
//
//    public String getDate() {
//        return Date;
//    }
//}
