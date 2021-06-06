package com.example.demo.Entity;

import javax.persistence.*;

@Entity
@Table(name = "employee")
public class Employee {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "ID")
    private long ID;
    @Column(name = "Name")
    private String name;
    @Column(name = "Branch_ID")
    private int Branch_Id;
    @Column(name = "Branch_Location")
    private String Location;
    @Column(name = "Mobile_Phone")
    private long MobilePhone;
    @Column(name = "Role")
    private String Role;
    @ManyToOne
    @JoinColumn(name="Branch_ID",insertable = false,updatable = false)
    Branch employeeBranch;

    public Branch getEmployeeBranch() {
        return employeeBranch;
    }

    public void setEmployeeBranch(Branch employeeBranch) {
        this.employeeBranch = employeeBranch;
    }

    public void setID(long ID) {
        this.ID = ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setBranch_Id(int branch_Id) {
        Branch_Id = branch_Id;
    }

    public void setLocation(String location) {
        Location = location;
    }

    public void setMobilePhone(long mobilePhone) {
        MobilePhone = mobilePhone;
    }

    public void setRole(String role) {
        Role = role;
    }

    public long getID() {
        return ID;
    }

    public String getName() {
        return name;
    }

    public int getBranch_Id() {
        return Branch_Id;
    }

    public String getLocation() {
        return Location;
    }

    public long getMobilePhone() {
        return MobilePhone;
    }

    public String getRole() {
        return Role;
    }
}
