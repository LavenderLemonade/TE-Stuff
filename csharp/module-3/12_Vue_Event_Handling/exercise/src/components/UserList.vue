<template>
  <div class="container">
    <table id="tblUsers">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
          <th>Email Address</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>
            <input type="checkbox" id="selectAll" v-on:click = "checkAllChecked" />
          </td>
          <td>
            <input type="text" id="firstNameFilter" v-model="filter.firstName" />
          </td>
          <td>
            <input type="text" id="lastNameFilter" v-model="filter.lastName" />
          </td>
          <td>
            <input type="text" id="usernameFilter" v-model="filter.username" />
          </td>
          <td>
            <input type="text" id="emailFilter" v-model="filter.emailAddress" />
          </td>
          <td>
            <select id="statusFilter" v-model="filter.status">
              <option value>Show All</option>
              <option value="Active">Active</option>
              <option value="Disabled">Disabled</option>
            </select>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr
          v-for="user in filteredList"
          v-bind:key="user.id"
          v-bind:class="{ disabled: user.status === 'Disabled' }"
        >
          <td>
            <input v-on:click = "checkIfChecked(user.id)" type="checkbox" v-bind:key = "user.id" class = "checkboxer" />
          </td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.username }}</td>
          <td>{{ user.emailAddress }}</td>
          <td>{{ user.status }}</td>
          <td>
            <button v-on:click = "flipStatus(user.id)" class="btnEnableDisable">{{checkOn(user.status)}}</button>
          </td>
        </tr>
      </tbody>
    </table>

    <div class="all-actions">
      <button v-bind:disabled = "(actionButtonDisabled ? false:true)" v-on:click = "enableSelectedUsers"  >Enable Users</button>
      <button v-bind:disabled = "(actionButtonDisabled ? false:true)"  v-on:click = "disableSelectedUsers">Disable Users</button>
      <button v-bind:disabled = "(actionButtonDisabled ? false:true)" v-on:click = "deleteSelectedUsers">Delete Users</button>
    </div>

    <button v-on:click = "showForm = !showForm">Add New User</button>

    <form  v-on:submit.prevent = "saveUser" id="frmAddNewUser"  v-show="showForm">
      <div class="field">
        <label for="firstName">First Name:</label>
        <input v-model="newUser.firstName" type="text" name="firstName" />
      </div>
      <div class="field">
        <label for="lastName">Last Name:</label>
        <input v-model="newUser.lastName" type="text" name="lastName" />
      </div>
      <div class="field">
        <label for="username">Username:</label>
        <input v-model="newUser.username" type="text" name="username" />
      </div>
      <div class="field">
        <label for="emailAddress">Email Address:</label>
        <input v-model="newUser.emailAddress" type="text" name="emailAddress" />
      </div>
      <button type="submit" class="btn save">Save User</button>
    </form>
  </div>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      selectedUserIDs: [],
      showForm: false,
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: ""
      },
      nextUserId: 7,
      newUser: {
        id: null,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active"
      },
      users: [
        {
          id: 1,
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active"
        },
        {
          id: 2,
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active"
        },
        {
          id: 3,
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled"
        },
        {
          id: 4,
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active"
        },
        {
          id: 5,
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active"
        },
        {
          id: 6,
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled"
        }
      ]
    };
  },
  methods: {
    checkAllChecked()
    {
      let allChecks = document.getElementById("selectAll");

      if (allChecks.checked == true)
      {
        let seeCheck = document.getElementsByClassName("checkboxer");

        for (let i = 0; i < seeCheck.length; i++)
        {
          seeCheck[i].checked = true;
          this.checkIfChecked(i+1);
        }


      }

      if (allChecks.checked != true)
      {
        let seeCheck = document.getElementsByClassName("checkboxer");

        for (let i = 0; i < seeCheck.length; i++)
        {
          seeCheck[i].checked = false;
          this.checkIfChecked(i+1);
        }
      }
    },
    checkIfChecked(id)
    {
      let seeCheck = document.getElementsByClassName("checkboxer");

      if (seeCheck[id-1].checked == true)
      {
        this.addID(id);
      }

      if (seeCheck[id-1].checked == false)
      {
        for (let i = 0; i < this.selectedUserIDs.length; i++)
        {
          if (this.selectedUserIDs[i] == id)
          {
            this.removeID(id);
          }
        }
      }

    },
    deleteSelectedUsers()
    {
      for (let i = 0; i < this.selectedUserIDs.length; i++)
      {
        for (let j = 0; j < this.users.length; j++)
        {
          if(this.selectedUserIDs[i] == this.users[j].id)
          {
            this.users.splice(j,1);
          }
        }
      }

      let checker = document.getElementsByClassName("checkboxer");

      for (let z = 0; z < checker.length; z++)
      {
        checker[z].checked = false;
      }
      this.selectedUserIDs = [];
    },
    disableSelectedUsers()
    {
      for (let i = 0; i < this.selectedUserIDs.length; i++)
      {
        for (let j = 0; j < this.users.length; j++)
        {
          if(this.selectedUserIDs[i] == this.users[j].id)
          {
            this.users[j].status = "Disabled"
          }
        }
      }

      let checker = document.getElementsByClassName("checkboxer");

      for (let z = 0; z < checker.length; z++)
      {
        checker[z].checked = false;
      }
    },
    enableSelectedUsers()
    {
      for (let i = 0; i < this.selectedUserIDs.length; i++)
      {
        for (let j = 0; j < this.users.length; j++)
        {
          if(this.selectedUserIDs[i] == this.users[j].id)
          {
            this.users[j].status = "Active"
          }
        }
      }

      let checker = document.getElementsByClassName("checkboxer");

      for (let z = 0; z < checker.length; z++)
      {
        checker[z].checked = false;
      }
    },
    removeID(id) {
      this.selectedUserIDs.splice(this.selectedUserIDs.indexOf(id),1);
    },
    addID(id) {
      this.selectedUserIDs.push(id);
    },
    getNextUserId() {
      return this.newUser.id = this.nextUserId;
    },
    saveUser(){
      this.getNextUserId();
      return this.users.push(this.newUser);
    },
    checkOn(x)
    {
      if (x == 'Active')
      {
        return  'Disable';
      }

      return 'Enable';
    },
    flipStatus(id)
    {
      let aUser;
      this.users.forEach((user) => {
        if (user.id === id) {
          aUser = user
        }
      })
      aUser.status = (aUser.status === "Active" ? "Disabled":"Active")
    }
  },
  computed: {
    actionButtonDisabled()
    {
      return (this.selectedUserIDs.length > 0 ? true:false)
    },
    filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.status === this.filter.status
        );
      }
      return filteredUsers;
    }
  }
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  margin-bottom: 20px;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}

form {
  margin: 20px;
  width: 350px;
}
.field {
  padding: 10px 0px;
}
label {
  width: 140px;
  display: inline-block;
}
button {
  margin-right: 5px;
}
.all-actions {
  margin-bottom: 40px;
}
.btn.save {
  margin: 20px;
  float: right;
}
</style>
